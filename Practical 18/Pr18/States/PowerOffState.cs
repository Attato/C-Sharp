using System;
using System.Collections.Generic;
using System.Text;

namespace Pr18.States
{
    class PowerOffState : IState
    {
        private readonly Printer _printer;

        public PowerOffState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("Принтер включен");
            _printer.SetState(_printer.WaitingState);
        }

        public void Off()
        {
            Console.WriteLine("Принтер и так выключен");
        }

        public void Print()
        {        
            Console.WriteLine("Принтер отключён, печать невозможна");
        }

        public void AddPaper(int count)
        {
            _printer.AddPater(count);          
            Console.WriteLine("Бумага добавлена");
        }
    }
}
