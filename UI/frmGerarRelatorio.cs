using BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static iTextSharp.text.TabStop;

namespace UI
{
    public partial class frmGerarRelatorio : Form
    {
        public ColaboradorBLL colaboradorBLL = new ColaboradorBLL();

        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            PreencherComboBoxColaboradores();
        }

        private string caminhoDestino;

        private void PreencherComboBoxColaboradores()
        {
            DataTable dt = colaboradorBLL.CarregarColaborador();

            cboxColaborador.DisplayMember = "Nome"; // Define a coluna a ser exibida
            cboxColaborador.ValueMember = "Id"; // Define a coluna a ser usada como valor selecionado
            cboxColaborador.DataSource = dt;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCaminhoRelatorio_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivos PDF (*.pdf)|*.pdf",
                Title = "Escolher o local de salvamento"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenha o caminho escolhido pelo usuário
                caminhoDestino = saveFileDialog.FileName;

                // Exiba o caminho no TextBox txtDestino
                txtCaminhoRelatorio.Text = caminhoDestino;
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                int idColaboradorSelecionado = (int)((DataRowView)cboxColaborador.SelectedItem)["Id"];

                AtendimentoBLL atendimentoBLL = new AtendimentoBLL();
                ColaboradorBLL colaboradorBLL = new ColaboradorBLL();

                Colaborador colaborador = colaboradorBLL.ObterColaboradorPorID(idColaboradorSelecionado);
                List<Atendimento> atendimentos = atendimentoBLL.ObterAtendimentosPorColaborador(idColaboradorSelecionado);

                using (FileStream fs = new FileStream(caminhoDestino, FileMode.Create))
                {
                    using (Document document = new Document())
                    {
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);

                        document.Open();

                        // Adicione o título
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
                        Paragraph title = new Paragraph("Informações do colaborador", titleFont)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        document.Add(new Chunk("\n"));
                        document.Add(title);

                        // Adicione o nome do colaborador
                        iTextSharp.text.Font nameFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY);
                        Paragraph name = new Paragraph("Nome: " + colaborador.NomeColaborador, nameFont)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        document.Add(new Chunk("\n"));
                        document.Add(name);

                        // Adicione o email do colaborador
                        iTextSharp.text.Font emailFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY);
                        Paragraph email = new Paragraph("E-mail: " + colaborador.EmailColaborador, emailFont)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        document.Add(email);
                        document.Add(new Chunk("\n"));

                        // Adicione o titulo de atendimento
                        iTextSharp.text.Font atendimentoFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK);
                        Paragraph titleAtendimento = new Paragraph("Informações do atendimento", atendimentoFont)
                        {
                            Alignment = Element.ALIGN_LEFT
                        };
                        document.Add(titleAtendimento);


                        // Adicione a tabela de atendimentos
                        PdfPTable atendimentoTable = new PdfPTable(3)
                        {
                            WidthPercentage = 100, // Preencha a largura da página
                            SpacingBefore = 8f // Adicione espaço antes da tabela
                        };

                        // Adicione cabeçalhos à tabela de atendimentos
                        atendimentoTable.AddCell(getHeaderCell("Código"));
                        atendimentoTable.AddCell(getHeaderCell("Data"));
                        atendimentoTable.AddCell(getHeaderCell("Status"));

                        // Adicione linhas à tabela de atendimentos
                        foreach (var atendimento in atendimentos)
                        {
                            atendimentoTable.AddCell(getCell(atendimento.CodigoAtendimento.ToString(), BaseColor.WHITE, BaseColor.BLACK, false));
                            atendimentoTable.AddCell(getCell(atendimento.DataAtendimento.ToString("dd/MM/yyyy"), BaseColor.WHITE, BaseColor.BLACK, false));
                            atendimentoTable.AddCell(getCell(atendimento.StatusAtendimento, BaseColor.WHITE, BaseColor.BLACK, false));
                        }

                        document.Add(atendimentoTable);
                        document.Add(new Chunk("\n"));

                        PdfPTable obsTable = new PdfPTable(1)
                        {
                            DefaultCell = { Border = iTextSharp.text.Rectangle.NO_BORDER },
                            WidthPercentage = 100, // Preencha a largura da página
                            SpacingBefore = 10f // Adicione espaço antes da tabela
                        };

                        obsTable.AddCell(getHeaderCell("Observações"));

                        obsTable.AddCell(getCell(txtObservacao.Text, BaseColor.LIGHT_GRAY, BaseColor.WHITE, false));

                        document.Add(obsTable);
                        document.Add(new Chunk("\n"));

                        // Adicione data e hora de geração do relatório
                        DateTime dataHoraAtual = DateTime.Now;
                        string dataHoraFormatada = "Data e hora de geração: " + dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
                        Paragraph dataHora = new Paragraph(dataHoraFormatada)
                        {
                            Alignment = Element.ALIGN_RIGHT
                        };
                        document.Add(dataHora);

                        // Feche o documento
                        document.Close();

                        MessageBox.Show("Relatório gerado com sucesso, salvo em: " + caminhoDestino, "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfPCell getHeaderCell(string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text))
            {
                BackgroundColor = new BaseColor(65, 105, 225), // Royal Blue
                HorizontalAlignment = Element.ALIGN_CENTER,
                BorderWidth = 0.5f, // Borda
                BorderColor = BaseColor.BLACK, // Cor da borda
                Padding = 5
            };

            // Defina a cor do texto como branca
            cell.Phrase.Font.Color = BaseColor.WHITE;
            cell.Phrase.Font.SetStyle(1); // Negrito

            return cell;
        }

        private PdfPCell getCell(string text, BaseColor backgroundColor, BaseColor textColor, bool alternateRowColor)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text))
            {
                BackgroundColor = alternateRowColor ? backgroundColor : BaseColor.WHITE,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5,
                Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER,
                BorderWidth = 0.5f,
                BorderColor = new BaseColor(63, 96, 35)
            };

            return cell;
        }
    }
}
