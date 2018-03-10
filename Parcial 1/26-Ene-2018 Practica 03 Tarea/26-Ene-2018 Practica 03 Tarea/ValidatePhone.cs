using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _26_Ene_2018_Practica_03_Tarea
{
    class ValidatePhone : IValidate
    {
        public bool validate(String val) { return Regex.Match(val, @"^(\[0-9]{9})$").Success; }
    }
}
