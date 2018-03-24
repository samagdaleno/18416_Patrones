using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Client
    {
        Invoker invoker;
        Reciever reciever;
        ICommand onCommand;
        ICommand offCommand;
        Stack<int> actions = new Stack<int>();
        public Client() {
            this.invoker = new Invoker();
            this.reciever = new Reciever();
            this.onCommand = new OnCommand(reciever);
            this.offCommand = new OffCommand(reciever);
            setCommands();
        }

        private void setCommands() {
            this.invoker.setCommand(onCommand, 0);
            this.invoker.setCommand(offCommand, 1);
        }

        public void action(int index) {
            invoker.pressButton(index);
            actions.Push(index);
        }

        public void undoAction(int index) {
            invoker.pressUndo(actions.Pop());
        }
    }
}
