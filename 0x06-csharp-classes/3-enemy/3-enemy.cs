using System;
/*
    Enemies namespace
 */
namespace Enemies
{
    /// <summary>The main Enemies Class</summary>
    class Zombie
    {
        ///<summary>public health value</summary>
        private int health;

        ///<summary>public zombie constructor</summary>
        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        
        ///<summary>public gethealth</summary>
        public int GetHealth() {
            return health;
        }
    }
}