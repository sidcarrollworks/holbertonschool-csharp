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
        /// <summary>private name field</summary>
        private string name = "(No name)";

        /// <summary>
        /// public property Name
        /// </summary>
        public string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }

        public Zombie() {
            health = 0;
        }

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

        /// <summary>
        /// overide to string
        /// </summary>
        /// <returns> formatted string</returns>
        public override string ToString() {
            return ("Zombie Name: " + name + " / " + "Total Health: " + health);
        }
    }
}