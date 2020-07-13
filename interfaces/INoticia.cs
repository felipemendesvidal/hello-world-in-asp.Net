//prevenção de erros por bibliotecas
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Text;
using  e_players.Models; //models
namespace e_players.interfaces
{
    public interface INoticia
    {
         //crar
        void Create(Noticia n);
        //ler
        List<Noticia> ReadAll();
        //alterar
        void Update(Noticia n);
        //excluir
        void Delete(int id);
    }
}