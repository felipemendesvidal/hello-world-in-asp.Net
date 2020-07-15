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
using E_players_2.Models;
namespace E_players_2.Interfaces{
    public interface INoticias{
        //metodos de crud
        void Create(Noticia n);

        List<Noticia> ReadAll();

        void Update(Noticia n);

        void Delete(int id);
         
    }//end interface INoticias
}//end namespace