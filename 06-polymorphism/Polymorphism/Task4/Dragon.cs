using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Dragon: IMonsters, IGamePlay
    {
        private double _x;
        private double _y;
        private double _speed;

        public Dragon (double x, double y, double speed)
        {
            this._x = x;
            this._y = y;
            this._speed = 0.75;
        }
        public void Hit(Player player) => player.GetDamage(70);
        public void Move(double x, double y)
        { }



    }
}
