using System;
using System.Collections.Generic;
using System.Text;

namespace Pr18.States
{
    interface IState
    {
        void On();
        void Off();
        void Print();
        void AddPaper(int count);
    }
}
