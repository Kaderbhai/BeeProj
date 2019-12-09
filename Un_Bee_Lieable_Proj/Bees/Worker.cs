using System.ComponentModel.DataAnnotations;

namespace Un_Bee_Lieable_Proj.Bees
{
    public class Worker : IBee
    {
        public float Health { get; private set; } = 100;

        public bool isDead { get; set; }

        public float Damage(int attackDamage)
        {
            if(attackDamage > 100 || attackDamage < 0)
            {
                return Health;
            }

            float damage = (float)attackDamage;

            if(Health < 70)
            {
                return Health;
            }
            else
            {
                Health = Health - damage;

                if(Health < 70)
                {
                    isDead = true;
                }
                return Health;
            }
        }
    }
}