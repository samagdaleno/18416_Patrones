﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class MediumCommand : ICommand
    {
        Reciever reciever;

        public MediumCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void execute()
        {
            Console.WriteLine("Executando OFF.");
            reciever.On();
        }

        public void undo()
        {
        }
    }
}
