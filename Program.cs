using System;

public interface IEnemy
{
    string? Name { get; set; }
    int Health { get; set; }
    int Damage { get; set; }
    void Attack();
}

public class Enemy : IEnemy
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public void Attack()
    {
        Console.WriteLine($"{Name} attacks for {Damage} damage!");
    }
}

public class Goblin : Enemy
{ 
    public Goblin()
    {
        Name = "Goblin";
        Health = 30;
        Damage = 5;
    }
}

public class Orc : Enemy
{
    public Orc()
    {
        Name = "Orc";
        Health = 15;
        Damage = 5;
    }
}

public class Dragon : Enemy
{
    public Dragon()
    {
        Name = "Dragon";
        Health = 100;
        Damage = 7;
    }
}

public class Tortuga : Enemy
{
    public Tortuga ()
    {
        Name = "Tortuga";
        Health = 10;
        Damage = 1;
    }
}

public class EnemyFactory
{
    public static IEnemy CreateEnemy(string type)
    {
        switch (type)
        {
            case "Goblin":
                return new Goblin();
            case "Orc":
                return new Orc();
            case "Dragon":
                return new Dragon();
            case "Tortuga":
                return new Tortuga();
            default:
                throw new ArgumentException("Tipo de enemigo desconocido");
        }
    }
}


class Program
{
    static void Main()
    {
        EnemyFactory enemyFactory = new EnemyFactory();

        for (int round = 1; round <= 5; round++)
        {
            Console.WriteLine($"\n=== Round {round} ===");
        
            IEnemy enemy1 = EnemyFactory.CreateEnemy("Orc");
            IEnemy enemy2 = EnemyFactory.CreateEnemy("Goblin");
            IEnemy enemy3 = EnemyFactory.CreateEnemy("Dragon");
            IEnemy enemy4 = EnemyFactory.CreateEnemy("Tortuga");
            
            enemy1.Attack();
            enemy2.Attack();
            enemy3.Attack();
            enemy4.Attack();
        }
    }
}
