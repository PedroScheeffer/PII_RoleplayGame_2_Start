using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell(70, 70) };

            Character gandalf = new Character("Gandalf");
            Item staff = new Item(100, 100);
            gandalf.items.Add(staff);
            gandalf.items.Add(book);

            Character gimli = new Character("Gimli");
            gimli.items.Add(new Item(25, 0));
            gimli.items.Add(new Item(0, 18));
            gimli.items.Add(new Item(0, 14));

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }
    }
}
