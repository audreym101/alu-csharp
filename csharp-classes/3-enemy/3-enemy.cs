using System;

namespace Enemies
{
    /// <summary>
    /// Zombie class
    /// </summary>
    public class Zombie
    {
        private int health;

        /// <summary>
        /// Constructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">Health value</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Get health
        /// </summary>
        /// <returns>Health value</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
