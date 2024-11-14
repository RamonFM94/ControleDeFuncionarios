using Dapper;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Repositories
{
    /// <summary>
    /// Implementação de repositório de funcionário
    /// para a gravação em banco de dados no SqlServer
    /// </summary>
    public class FuncionarioRepositorySql : IFuncionarioRepository
    {
        #region Atributos
        private string _connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDProjetoAula04;Integrated Security=True;";
        #endregion

        public void ExportarDados(Funcionario funcionario)
        {
            using (var connection = new SqlConnection(_connection))
            {
                //executar o comando sql para inserir um funcionário na tabela do banco (INSERT)
                connection.Execute("INSERT INTO FUNCIONARIO(ID, NOME, CPF, SALARIO, TIPO) VALUES(@ID, @NOME, @CPF, @SALARIO, @TIPO)",
                    new
                    {
                        @ID = funcionario.Id,
                        @NOME = funcionario.Nome,
                        @CPF = funcionario.Cpf,
                        @SALARIO = funcionario.Salario,
                        @TIPO = funcionario.Tipo

                    });
            }


        }
    }
}
