﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Dapper;
using model;

namespace DAL
{
    public class FamiliaDAL
    {
        ConexaoDB mConn = new ConexaoDB();

        public List<Familia> ObterFamilias()
        {
            using (MySqlConnection conn = mConn.AbrirConexao())
            {
                string query = "SELECT Id, Sobrenome, Responsavel, Participantes FROM tb_familias";
                return conn.Query<Familia>(query).AsList();
            }
        }

        public  Familia ObterFamiliaPorID(int idFamilia)
        {
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                string query = "SELECT * FROM tb_familias WHERE Id = @IdFamilia";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdFamilia", idFamilia);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Familia familia = new Familia
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Sobrenome = reader["Sobrenome"].ToString(),
                            Responsavel = reader["Responsavel"].ToString(),
                            Participantes = Convert.ToInt32(reader["Participantes"]),
                            NomeFamilia = reader["NomeFamilia"].ToString()
                        };
                        return familia;
                    }
                    return null; // Se não encontrou o colaborador
                }
            }
        }
    }
}
