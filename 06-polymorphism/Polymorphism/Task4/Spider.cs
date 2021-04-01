using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Spider : IMonsters
    {
        private double _x;
        private double _y;
        private double _speed;

        public Spider(double x, double y, double speed)
        {
            this._x = x;
            this._y = y;
            this._speed = 1.25;
        }
        public void Hit(Player player) => player.GetDamage(25);
        public void Move(double x, double y)
        { }



    }
}
