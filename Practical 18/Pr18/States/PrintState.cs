using System;
using System.Collections.Generic;
using System.Text;

namespace Pr18.States
{
    class PrintState : IState
    {
        private readonly Printer _printer;

        public PrintState(Printer printer)
        {
            _printer = printer;
        }

        public void On()
        {
            Console.WriteLine("Принтер уже и так включен");
        }

        public void Off()
        {
            Console.WriteLine("Принтер выключен");
        }

        public void Print()
        {
            if (_printer.CountPaper > 0)
            {
                Console.WriteLine("Идёт печать...");
                _printer.AddPater(-1);
                _printer.SetState(_printer.WaitingState);
            }
            else
            {
                _printer.SetState(_printer.PapperOffState);
                _printer.PrintDocument();
            }
        }

        public void AddPaper(int count)
        {
            _printer.AddPater(count);
            Console.WriteLine("Бумага добавлена");
        }
    }
}
