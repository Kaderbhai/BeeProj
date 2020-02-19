namespace  Un_Bee_Lieable_Proj.Bees
{
    public interface IBee
    {
        float Health { get; set; }

        bool IsDead { get; set; }

        // rANGE MUST BE 0 - 100
        float Damage(int attackDamage);
        
    }
}