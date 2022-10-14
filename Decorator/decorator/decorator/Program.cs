using System;

namespace decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Card soldier = new Card("Soldier", 25, 20);
            soldier = new AttackDecorator(soldier, "Sword", 15);
            soldier = new AttackDecorator(soldier, "Amulet", 5);
            soldier = new DefenseDecorator(soldier, "Helmet", 10);
            soldier = new DefenseDecorator(soldier, "Heavy Armor", 45);
            Console.WriteLine($"Final Stats: {soldier.Attack} / {soldier.Defense}");
            
            Console.ReadKey();
        }
    }
}