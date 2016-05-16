using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Invoke
    {
        //不明白为什么要这样写
        public Command Command;

        public Invoke(Command command)
        {
            this.Command = command;
        }

        public void Execute()
        {
            Command.Action();
        }
    }
}
