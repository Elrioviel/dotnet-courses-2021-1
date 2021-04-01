using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    interface IMonsters:IGamePlay
    {
        public void Hit(Player player);
    }
}
