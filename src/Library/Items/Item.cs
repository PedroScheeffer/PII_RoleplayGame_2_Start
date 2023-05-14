namespace RoleplayGame
{
    public class Item : IItem
    {
        public int DefenseValue{get;  set;}
        public int AttackValue{get;  set;}
        public Item(int attack, int defense)
        {
            DefenseValue = defense;
            AttackValue = attack;
        }
    }
}