using System;
using System.Collections.Generic;

namespace Weapon.cs
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Weapon
    {
        public uint Damage { get; private set; }
        public uint Bullets { get; private set; }

        public void Fire()
        {
            if(Bullets > 0)
            {
                Bullets -= 1;
            }
        }
    }

    class Player
    {
        public readonly uint MaxHealth;

        public bool IsDead { get; private set; }

        private uint _currentHealth;


        public Player()
        {
            _currentHealth = MaxHealth;
            IsDead = false;
        }

        private bool Dead()
        {
            return IsDead = true;
        }

        public void ApplyDamage(uint damage)
        {
            if (IsDead == false)
                _currentHealth -= damage;

            if (_currentHealth <= 0)
                IsDead = Dead();
        }
    }

    class Bot
    {
        public Weapon Weapon;

        public void OnSeePlayer(Player player)
        {
            player.ApplyDamage(Weapon.Damage);
        }
    }
}
