using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2___Profª_Kátia___RA._6322092
{
    internal class Filme
    {
        string titulo;
        string sinopse;
        string genero;
        string clasificacao;

        public void Receber(string ti, string si, string ge, string cl)
        {
            this.titulo = ti;
            this.sinopse = si;
            this.genero = ge;
            this.clasificacao = cl;

        }
        public string Mostrar()
        {
            return "Titulo = " + this.titulo +
                "\nSinopse = " + this.sinopse +
                "\nGênero = " + this.genero +
                "\nclasificação = " + this.clasificacao;
        }

    }
}