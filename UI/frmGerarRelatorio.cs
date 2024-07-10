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
        private readonly AtendimentoBLL atendimentoBLL = new AtendimentoBLL();
        private readonly ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        private string caminhoDestino;

        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorio_Load(object sender, EventArgs e)
        {
            PreencherComboBoxColaboradores();
            PreencherComboBoxCodigos();
        }

        private void PreencherComboBoxColaboradores()
        {
            List<Colaborador> colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor();
            cboxColaborador.DataSource = colaboradores;
            cboxColaborador.DisplayMember = "NomeColaborador"; // Define o campo a ser exibido no ComboBox
            cboxColaborador.ValueMember = "IdColaborador"; // Define o campo do valor selecionado
            cboxColaborador.SelectedIndex = -1;
        }

        private void PreencherComboBoxCodigos()
        {
            List<Atendimento> atendimentos = atendimentoBLL.GetAtendimentos();
            cboxCodigo.DataSource = atendimentos;
            cboxCodigo.DisplayMember = "CodigoAtendimento"; // Define o campo a ser exibido no ComboBox
            cboxCodigo.ValueMember = "IdAtendimento"; // Define o campo do valor selecionado
            cboxCodigo.SelectedIndex = -1;
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
                caminhoDestino = saveFileDialog.FileName;
                txtCaminhoRelatorio.Text = caminhoDestino;
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxColaborador.SelectedItem != null && cboxColaborador.SelectedItem is Colaborador)
                {
                    Colaborador colaboradorSelecionado = (Colaborador)cboxColaborador.SelectedItem;

                    List<Atendimento> atendimentos = new List<Atendimento>();

                    if (cboxCodigo.SelectedItem != null && cboxCodigo.SelectedItem is Atendimento)
                    {
                        Atendimento codigoSelecionado = (Atendimento)cboxCodigo.SelectedItem;
                        string codigoAtendimento = codigoSelecionado.CodigoAtendimento;

                        // Buscar apenas o atendimento com o código especificado
                        Atendimento atendimento = atendimentoBLL.ObterAtendimentoPorCodigo(codigoAtendimento);
                        if (atendimento != null)
                            atendimentos.Add(atendimento);
                    }
                    else
                    {
                        // Buscar todos os atendimentos do colaborador
                        atendimentos = atendimentoBLL.ObterAtendimentosPorColaborador(colaboradorSelecionado.IdColaborador);
                    }

                    if (atendimentos.Count > 0)
                    {
                        using (FileStream fs = new FileStream(caminhoDestino, FileMode.Create))
                        {
                            using (Document document = new Document())
                            {
                                PdfWriter writer = PdfWriter.GetInstance(document, fs);

                                document.Open();

                                // Adicione o título do colaborador
                                Paragraph titleColaborador = new Paragraph("Informações do colaborador", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK));
                                titleColaborador.Alignment = Element.ALIGN_LEFT;
                                document.Add(titleColaborador);
                                document.Add(new Chunk("\n"));

                                // Adicione detalhes do colaborador
                                Paragraph detailsColaborador = new Paragraph();
                                detailsColaborador.Add(new Chunk("Nome: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk(colaboradorSelecionado.NomeColaborador, FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk("\n"));
                                detailsColaborador.Add(new Chunk("E-mail: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk(colaboradorSelecionado.EmailColaborador, FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk("\n"));
                                detailsColaborador.Add(new Chunk("Cargo: ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk(colaboradorSelecionado.NomeCargo, FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.DARK_GRAY)));
                                detailsColaborador.Add(new Chunk("\n\n"));
                                document.Add(detailsColaborador);

                                // Adicione o título dos atendimentos
                                Paragraph titleAtendimentos = new Paragraph("Informações do atendimento", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.BLACK));
                                titleAtendimentos.Alignment = Element.ALIGN_LEFT;
                                document.Add(titleAtendimentos);
                                document.Add(new Chunk("\n"));

                                foreach (var atendimento in atendimentos)
                                {
                                    // Adicione informações principais do atendimento
                                    PdfPTable atendimentoTable = new PdfPTable(4);
                                    atendimentoTable.WidthPercentage = 100;
                                    //atendimentoTable.SpacingBefore = 5f;

                                    // Adicione cabeçalhos à tabela de atendimentos
                                    atendimentoTable.AddCell(getHeaderCell("Código"));
                                    atendimentoTable.AddCell(getHeaderCell("Data"));
                                    atendimentoTable.AddCell(getHeaderCell("Status"));
                                    atendimentoTable.AddCell(getHeaderCell("Atendente"));

                                    // Adicione dados do atendimento
                                    atendimentoTable.AddCell(getCell(atendimento.CodigoAtendimento, BaseColor.WHITE, BaseColor.BLACK, false)); // Código como string
                                    atendimentoTable.AddCell(getCell(atendimento.DataAtendimento.ToString(), BaseColor.WHITE, BaseColor.BLACK, false));
                                    atendimentoTable.AddCell(getCell(atendimento.StatusAtendimento, BaseColor.WHITE, BaseColor.BLACK, false));
                                    atendimentoTable.AddCell(getCell(atendimento.NomeAtendente, BaseColor.WHITE, BaseColor.BLACK, false));

                                    document.Add(atendimentoTable);
                                    document.Add(new Chunk("\n"));

                                    // Adicione tabela de descritivo do atendimento
                                    PdfPTable descritivoTable = new PdfPTable(1);
                                    descritivoTable.WidthPercentage = 100;
                                    descritivoTable.SpacingBefore = 10f;

                                    descritivoTable.AddCell(getHeaderCell("Descritivo do Atendimento"));
                                    descritivoTable.AddCell(getCell(atendimento.DescritivoAtendimento, BaseColor.WHITE, BaseColor.BLACK, false));

                                    document.Add(descritivoTable);
                                    document.Add(new Chunk("\n"));
                                }

                                // Adicione as observações finais
                                PdfPTable obsTable = new PdfPTable(1);
                                obsTable.WidthPercentage = 100;
                                obsTable.SpacingBefore = 10f;

                                obsTable.AddCell(getHeaderCell("Observações finais"));
                                obsTable.AddCell(getCell(txtObservacao.Text, BaseColor.LIGHT_GRAY, BaseColor.WHITE, false));

                                document.Add(obsTable);
                                document.Add(new Chunk("\n"));

                                // Adicione data e hora de geração do relatório
                                DateTime dataHoraAtual = DateTime.Now;
                                string dataHoraFormatada = "Data e hora de geração: " + dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
                                Paragraph dataHora = new Paragraph(dataHoraFormatada);
                                dataHora.Alignment = Element.ALIGN_RIGHT;
                                document.Add(dataHora);

                                // Feche o documento
                                document.Close();

                                MessageBox.Show("Relatório gerado com sucesso, salvo em: " + caminhoDestino, "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foram encontrados atendimentos para o colaborador selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um colaborador válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                BorderWidth = 0.5f,
                BorderColor = BaseColor.BLACK,
                Padding = 5
            };

            cell.Phrase.Font.Color = BaseColor.WHITE;
            cell.Phrase.Font.SetStyle(1); // Negrito

            return cell;
        }

        private PdfPCell getCell(string text, BaseColor backgroundColor, BaseColor textColor, bool alternateRowColor)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text))
            {
                BackgroundColor = alternateRowColor ? backgroundColor : BaseColor.WHITE,
                HorizontalAlignment = Element.ALIGN_LEFT,
                Padding = 5,
                BorderWidth = 0.5f,
                BorderColor = BaseColor.BLACK
            };

            return cell;
        }
    }
}
