using Newtonsoft.Json;
using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Repositories
{
    public class FuncionarioRepositoryJson : IFuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            //converter os dados do funcionário em JSON
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            //abrindo um arquivo para gravação
            var streamWritter = new StreamWriter("C:\\temp\\funcionarios.json",true);

            //gravar os dados no arquivo
            streamWritter.WriteLine(json);
            //fechando o arquivo
            streamWritter.Close();
            
        }
    }
}
