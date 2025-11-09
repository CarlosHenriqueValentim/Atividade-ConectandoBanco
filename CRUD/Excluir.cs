using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    internal class Excluir
    {
        public static void ExcluirAluno(string conexao)
        {
            Console.Write("Id do aluno a excluir:");
            string idTexto = Console.ReadLine();
            int id;
            if (!int.TryParse(idTexto, out id))
            {
                Console.WriteLine("\nId inválido\n");
                return;
            }

            string sql = "DELETE FROM alunos WHERE Id = @id";
            try
            {
                MySqlConnection conn = Program.GetConnection(conexao);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                int linhas = cmd.ExecuteNonQuery();
                Console.WriteLine(linhas + " registro(s) excluído(s).");

                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("\nErro ao excluir:" + mex.Message);
            }
        }
    }
}
