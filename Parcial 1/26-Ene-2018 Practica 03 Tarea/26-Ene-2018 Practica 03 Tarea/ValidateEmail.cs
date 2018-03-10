using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2018_Practica_03_Tarea
{
    class ValidateEmail : IValidate
    {
        public bool validate(String val) {

            try {
                var addr = new System.Net.Mail.MailAddress(val);
                return addr.Address == val;
            }
            catch{
                return false;
            }

        }
    }
}
