using ProjetoAula04.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Entities
{
    /// <summary>
    /// Modelo de dados de entidade para funcionário.
    /// </summary>
    public class Funcionario
    {
        #region Propriedades
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
        public TipoDeContratacao Tipo { get; set; }

        #endregion

        #region Construotores
        public Funcionario()
        {
            Id = Guid.NewGuid();
            
        }
        #endregion

    }
}
