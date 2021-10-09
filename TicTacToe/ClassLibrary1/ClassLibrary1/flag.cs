using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross.Common
{
    public class Flag
    {
        // Определяет победителя (1 = кто-то выйграл; -1 = ничья; 0 = матч в процессе)
        int flag = 0;
        public int GetFlag()
        {
            return flag;
        }
        public void SetFlag(int value)
        {
            flag = value;
        }

       // public int FlagValue {get; set;}
    }
}
