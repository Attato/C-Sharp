using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross.Common
{
    public class Choice
    {
        int choice; //Позиция выбора
        public int GetChoice()
        {
            return choice;    
        }
        public void SetChoice(int value)
        {
            choice = value;
        }
    }
}
