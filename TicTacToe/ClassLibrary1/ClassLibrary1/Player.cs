using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross.Common
{
    public class Player
    {
        int player = 1;

        public int GetPlayer()
        {
            return player;
        }
        public void SetPlayer(int value)
        {
            player = value;
        }
    }
}
