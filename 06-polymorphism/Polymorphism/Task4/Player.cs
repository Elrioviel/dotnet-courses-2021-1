using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Player : IGamePlay
    {
        private int _health;
        private int _mana;
        private double _x, _y;
        private double _speed;
        private int _maxHealth = 100;

        public Player(double x, double y, int health, int mana, double speed)
        {
            this._x = x;
            this._y = y;
            this._health = 100;
            this._mana = mana;
            this._speed = 1;
        }
        public void Move(double x, double y)
        { }
        public void GetDamage(int dmg)
        {
            _health -= dmg;
        }
        public void GetHeal(int heal)
        {
            if (_health < _maxHealth)
            {
                _health += 50;
            }
            else
            {
                _health += 10;
            }
        }
        public void GetMana(int mana)
        {
            _mana += _mana / 2;

        }
        public void GetSpeed(int speed)
        {
            _speed += speed;
        }
    }
}
