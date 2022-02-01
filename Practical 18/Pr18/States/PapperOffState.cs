using System;
using System.Collections.Generic;
using System.Text;

namespace Pr18.States
{
    class PapperOffState : IState
    {
        private readonly Printer _printer;

        public PapperOffState(Printer printer)
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
            _printer.SetState(_printer.PowerOffState);
        }

        public void Print()
        {
            if (_printer.CountPaper > 0)
            {
                _printer.SetState(_printer.PrintState);
                _printer.PrintDocument();
            }
            else
            {
                Console.WriteLine("Бумаги нет, печатать не буду");
            }
        }

        public void AddPaper(int count)
        {
            Console.WriteLine("Добавляем бумагу");
            _printer.AddPater(count);
            if (_printer.CountPaper > 0)
                _printer.SetState(_printer.WaitingState);
        }
    }
}
