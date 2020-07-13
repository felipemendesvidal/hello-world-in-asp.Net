//prevenção de erros por bibliotecas
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;

namespace e_players.Models
{
    //herdar eplayers_base,Iequipe
    public class Equipe:EplayersBase,IEquipe{
        //propriedades
        public int IdEquipe{get; set;}
        public string Nome{get; set;}
        public string Imagem{get; set;}
        private const string PATHS ="C:/Users/Phellipe/Desktop/senai/c#/e_players/Database/equipe.csv";//caminho diretorio e arquivo

        //contrutor
        /// <summary>
        /// Esse metodo cria o dietorio e o arquivo
        /// </summary>
        public Equipe(){
            CriarDiretorioeArquivo(PATHS);
        }//fim contrutor

        //interface
        //criar
        /// <summary>
        /// Cria as linhas no csv
        /// </summary>
        /// <param name="e"> parametro </param>
        public void Criar(Equipe e){
            string[] linha_arquivo ={ Preparar(e) };
            File.AppendAllLines(PATHS,linha_arquivo);
        }//fim do metodo criate

        /// <summary>
        /// prepara as linhas no csv
        /// </summary>
        /// <param name="e">parametro</param>
        /// <returns></returns>
        private string Preparar(Equipe e){
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }//fim do metodo preparar

        //ler
        public List<Equipe> ReadAll(){

        }//fim do metodo ler

        //alterar
        public void Update(Equipe e){

        }//fim do metodo alterar

        //excluir
        public void Delete(int id){

        }//fim do metodo deletar




        
    }//fim da classe principal * public class equipe
}