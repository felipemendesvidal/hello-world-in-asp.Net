//prevenção de erros por bibliotecas
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
namespace e_players.Models
{
    public class EplayersBase{
        /// <summary>
        /// Metodo que cria arquivo e diretorio 
        /// </summary>
        /// <param name="a_caminho">caminho do diretorio em string</param>
        public void CriarDiretorioeArquivo(string a_caminho){
            string diretorio = a_caminho.Split("/")[0];
            string arquivo = a_caminho.Split("/")[1];

            //DIRETORIO
            if(!Directory.Exists(diretorio)){
                Directory.CreateDirectory(diretorio);
            }//fim do if

            //ARQUIVO
            if(!File.Exists(a_caminho)){
                File.Create(a_caminho).Close();
            }//fim do if
        }//fim do criar arquivo e diretorio

        /// <summary>
        /// Metodo que le todas as linhas de um csv
        /// </summary>
        /// <param name="l_caminho">caminho do csv</param>
        /// <returns>retorna todas as linhas desse csv</returns>
        public List<string> LerTodasAsLinhas(string l_caminho){
            List <string> linhas_arquivo = new List<string>();
            using(StreamReader arquivo = new StreamReader(l_caminho)){
                string linhaLida;
                while (linhaLida = arquivo.ReadLine()){
                    linhas_arquivo.Add(linhaLida);
                }//fim do while
            }//fim do using
            return linhas_arquivo;
        }//fim do metodo ler

        /// <summary>
        /// Esse metodo le as linhas e reescreve elas
        /// </summary>
        /// <param name="r_caminho">caminho do csv</param>
        /// <param name="linhas_arquivo">linhas analisadas do arquivo do arquivo</param>
        public void ReescreverCSV(string r_caminho, List<string> linhas_arquivo){
            using(StreamWriter saida = new StreamWriter(r_caminho)){
                foreach(var item in linhas_arquivo){
                    saida.Write(item + "\n");
                }//fim foreach
            }//fim do using
        }//fim do metodo reescrever 
    }//fim da classe principal * epla
}