using UnityEngine;

namespace Enemies
{
    abstract class Enemy : MonoBehaviour
    {
        public Enemy(float health)
        {
            this.health = health; 
        }

        public float health;
        abstract public void GetDamage(int damage);        
    }    
}
