using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class PartyCommand : ICommand
    {
        List<ICommand> commandList;

        public PartyCommand(List<ICommand> commandList)
        {
            this.commandList = commandList;
        }
        public void execute()
        {
            Console.WriteLine("EXECUTING PARTY COMMAND: ");
            foreach (ICommand command in this.commandList) 
                command.execute();
        }

        public void undo()
        {
            Console.WriteLine("UNDOING PARTY COMMAND: ");
            this.commandList.Reverse();
            foreach (ICommand command in this.commandList)
                command.undo();
        }
    }
}
