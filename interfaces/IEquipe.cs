//prevenção de erros por bibliotecas
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
using e_players.Models; //models
namespace e_players.interfaces
{
    public interface IEquipe
    {
        //crar
        void Create(Equipe e);
        //ler
        List<Equipe> ReadAll();
        //alterar
        void Update(Equipe e);
        //excluir
        void Delete(int id);
    }
}