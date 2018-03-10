using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Ene_2018_Practica_03_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            StringField email = new StringField();
            StringField number = new StringField();
            StringField phoneNumber = new StringField();

            email.validationType = new ValidateEmail();
            number.validationType = new ValidateNumber();
            phoneNumber.validationType = new ValidatePhone();

            Console.WriteLine("SAMI VALIDATIONS 3002!");
            while (true)
            {
                Console.WriteLine("PLEASE CHOOSE WHAT TO VALIDATE: ");
                Console.WriteLine("1. Email");
                Console.WriteLine("2. Number");
                Console.WriteLine("3. Phone Number (9 Digits)");
                Console.WriteLine("4. Exit \n");
                String opcion = Console.ReadLine();


                if (opcion.Equals("1")) {
                    Console.WriteLine("PLEASE INPUT AN EMAIL, MY MAN:");
                    email.value = Console.ReadLine();
                    bool isit = email.validationType.validate(email.value);

                    if (isit)
                        Console.WriteLine("THAT IS ONE HELL OF A VALID EMAIL, MY DUDE!\n");
                    else
                        Console.WriteLine("THAT'S NOT A VALID EMAIL, MY MAN!\n");
                }

                else if(opcion.Equals("2"))
                {
                    Console.WriteLine("PLEASE INPUT A COOL NUMBER, MY MAN:");
                    number.value = Console.ReadLine();
                    bool isit = number.validationType.validate(number.value);

                    if (isit)
                        Console.WriteLine("THAT IS ONE HELL OF A VALID NUMBER, MY DUDE!\n");
                    else
                        Console.WriteLine("THAT'S NOT A VALID NUMBER, MY MAN!\n");
                }

                else if(opcion.Equals("3"))
                {
                    Console.WriteLine("PLEASE INPUT A 9 DIGIT PHONE NUMBER, MY MAN:");
                    phoneNumber.value = Console.ReadLine();
                    bool isit = phoneNumber.validationType.validate(phoneNumber.value);

                    if (isit)
                        Console.WriteLine("THAT IS ONE HELL OF A VALID PHONE NUMBER, MY DUDE!\n");
                    else
                        Console.WriteLine("THAT'S NOT A VALID PHONE NUMBER, MY MAN!\n");

                }


                else if (opcion.Equals("4"))
                    break;

                else
                    Console.WriteLine("THAT'S NOT AN OPTION, MY DUDE!\n");
            }


        }
    }
}
