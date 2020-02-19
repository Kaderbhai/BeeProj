using System.ComponentModel.DataAnnotations;

namespace Un_Bee_Lieable_Proj.Bees
{
    public class Queen: IBee
    {
        public Queen(float health, bool isDead)
        {
            Health = health;
            IsDead = isDead;
        }
        public float Health { get; set; }

        public bool IsDead { get; set; }

        public float Damage(int attackDamage)
        {
            if(attackDamage > 100 || attackDamage < 0)
            {
                return Health;
            }

            float damage = (float)attackDamage;

            if(Health < 20)
            {
                return Health;
            }
            else
            {
                Health = Health - damage;

                if(Health < 20)
                {
                    IsDead = true;
                }
                return Health;
            }
        }
    }
}