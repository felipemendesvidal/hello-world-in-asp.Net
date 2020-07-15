//prevenção de erros por bibliotecas
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace E_players_2.Models{
    public class EplayersBase{
        /// <summary>
        /// Cria o arquivo e o diretorios
        /// </summary>
        /// <param name="_path">precisa de uma string com um caminho para salvar os arquivos</param>
        public void CreateFolderAndFile(string _path){

            string folder   = _path.Split("/")[0];
            string file     = _path.Split("/")[1];

            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }//end if

            if(!File.Exists(_path)){
                File.Create(_path).Close();
            }//end if
        }//end void createfolderandfile

        /// <summary>
        /// metodo que le todas as linhas dos csv
        /// </summary>
        /// <param name="PATH">caminho</param>
        /// <returns>linhas do csv</returns>
        public List<string> ReadAllLinesCSV(string PATH){
            
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(PATH))
            {
                string linha;
                while((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }//end while
            }//end using
            return linhas;
        }//end readalllinescsv

        /// <summary>
        /// metodo que reescreve as linhas do csv
        /// </summary>
        /// <param name="PATH">caminho</param>
        /// <param name="linhas">lista com linhas novas</param>
        public void RewriteCSV(string PATH, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + "\n");
                }//end foreach
            }//end using
        }//end rewrite
    }//end class eplayersBase
}//end namespace