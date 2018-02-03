using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2018_Practica_03_Tarea
{
    abstract class FormField
    {
        public IValidate validationType { get; set; }
        public String value { get; set; }
        public bool isValid { get; set; }
        public bool validate (String value) { return true; }
    }
}
