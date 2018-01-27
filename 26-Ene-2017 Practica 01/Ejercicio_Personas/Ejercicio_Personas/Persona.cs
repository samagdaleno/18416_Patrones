using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Personas
{
    class Persona
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public Walkable WalkBehavior{ get; set; }

        public void Comer (){
        }

        public void Defecar() {
        }

        public void Caminar() {
        }

        public Persona(){ }


    }
}
