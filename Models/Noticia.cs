//prevenção de erros por bibliotecas
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;

namespace e_players.Models{
    //herdar eplayers-base, Inoticia
    public class Noticia:EplayersBase,INoticia{
        //propriedades
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Imagem { get; set; }
        private const string PATHS ="C:/Users/Phellipe/Desktop/senai/c#/e_players/Database/equipe.csv";//caminho diretorio e arquivo

        //contrutor
        /// <summary>
        /// Esse metodo cria o dietorio e o arquivo
        /// </summary>
        public Noticia(){
            CriarDiretorioeArquivo(PATHS);
        }//fim contrutor

        //interface
        //criar
        /// <summary>
        /// Cria as linhas no csv
        /// </summary>
        /// <param name="n"> parametro </param>
        public void Criar(Noticia n){
            string[] linha_arquivo ={ Preparar(n) };
            File.AppendAllLines(PATHS,linha_arquivo);
        }//fim do metodo criate

        /// <summary>
        /// prepara as linhas no csv
        /// </summary>
        /// <param name="n">parametro</param>
        /// <returns></returns>
        private string Preparar(Noticia n){
            return $"{n.IdEquipe};{n.Nome};{n.Imagem}";
        }//fim do metodo preparar

        //ler
        public List<Noticia> ReadAll(){
            
        }//fim do metodo ler

        //alterar
        public void Update(Noticia n){

        }//fim do metodo alterar

        //excluir
        public void Delete(int id){

        }//fim do metodo aterar






        
        
    }// fim da classe principal * public class noticia
}