using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspasaF.ProgramacionEval1.Juego.Logica;

namespace EspasaF.ProgramacionEval1.Juego.Logica.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = Logica.ModeloJuego.SecretoDeLaVida();

            Console.WriteLine("El secreto de la vida es " + secreto);
            Console.ReadKey();
        }
    }
}
