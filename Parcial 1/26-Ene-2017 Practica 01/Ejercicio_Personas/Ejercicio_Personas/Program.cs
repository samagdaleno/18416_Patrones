using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona memilio = new Persona();
            memilio.Age = 25;
            memilio.Name = "Memilio Gómez";
            memilio.WalkBehavior = new CaminarDePies();

            Profesor prof = new Profesor();
            prof.WalkBehavior = new CaminarDePies();

            Estudiante est = new Estudiante();
            est.WalkBehavior = new NoCaminar();

            Chofer chof = new Chofer();
            chof.WalkBehavior = new CaminarManos();



            


            
        }
    }
}
