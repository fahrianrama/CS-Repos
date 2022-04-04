using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Monster
{
    public string type = "Goblin";
    public int health = 100;
    public int damage = 0;
    public void AttackWar(Warrior player,int reduce)
    {
        Random randomizer = new Random();
        damage = randomizer.Next(1, 10);
        player.health -= damage - reduce;
    }
    public void AttackWiz(Mage player)
    {
        Random randomizer = new Random();
        damage = randomizer.Next(1, 10);
        player.health -= damage;
    }
}
public class Player
{
    public string name;
    public int age;
    public string country;
    public Player(string name, int age, string country)
    {
        this.name = name;
        this.age = age;
        this.country = country;
    }
    public void ShowSelf()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Country: {0}", country);
    }
    public void ShowStatus()
    {
        Console.WriteLine("Player {0} is {1} years old and lives in {2}", name, age, country);
    }
}

public class Warrior : Player
{
    public int health = 100;
    public int damage = 10;
    public int armor = 10;
    public int stamina = 100;
    public int mana = 0;
    
    public Warrior(string name, int age, string country) : base(name, age, country)
    {
        this.name = name;
        this.age = age;
        this.country = country;
    }
    public void ShowSelf()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Country: {0}", country);
        Console.WriteLine("Health: {0}", health);
        Console.WriteLine("Damage: {0}", damage);
        Console.WriteLine("Stamina: {0}", stamina);
    }
    public void Attack(Monster monster){
        monster.health -= damage;
        Console.WriteLine("{0} attacks {1} and deals {2} damage", name, monster.type, damage);
    }
    public int Defend(int damage)
    {
        Random rand = new Random();
        int damagereduce = rand.Next(0, damage);
        stamina -= 25;
        Console.WriteLine("{0} defends {1} damages!", name, damagereduce);
        return damagereduce;
    }
}
public class Mage : Player
{
    public int health = 75;
    public int damage = 2;
    public int mana = 100;
    public Mage(string name, int age, string country) : base(name, age, country)
    {
        this.name = name;
        this.age = age;
        this.country = country;
    }
    public void Attack(Monster monster)
    {
        monster.health -= damage;
        Console.WriteLine("{0} attacks {1} and deals {2} damage", name, monster.type, damage);
    }
    public void Spell(Monster monster)
    {
        Random rand = new Random();
        damage = rand.Next(5, 20);
        if (mana < 15)
        {
            Console.WriteLine("Your mana isn't enough to cast spell!");
        }
        else
        {
            mana -= 15;
            Console.WriteLine("{0} casts a spell on {1} and deals {2} damage", name, monster.type, damage);
            monster.health -= damage;
        }
    }
    public void ShowSelf()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Country: {0}", country);
        Console.WriteLine("Health: {0}", health);
        Console.WriteLine("Damage: {0}", damage);
        Console.WriteLine("Mana: {0}", mana);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Declare new player & monster
        Warrior warrior = new Warrior("", 0, "");
        Mage mage = new Mage("", 0, "");
        Monster monster = new Monster();

        // Menu
        string batas = "===========================================";
        Console.WriteLine(batas);
        Console.WriteLine("Welcome to the game!");
        Console.WriteLine(batas);
        Console.WriteLine("What do you want to be?\n1. Warrior\n2. Mage");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Input Data
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter country: ");
        string country = Console.ReadLine();
        Console.WriteLine(batas);
        string className = "";
        Console.Clear();
        // Assign data to player
        if (choice == 1)
        {
            warrior = new Warrior(name, age, country);
            Console.WriteLine(batas);
            Console.WriteLine("You are a warrior!");
            Console.WriteLine(batas);
            Console.WriteLine("Your Data & Stats : ");
            Console.WriteLine(batas);
            warrior.ShowSelf();
            className = "Warrior";
        }
        else if (choice == 2)
        {
            mage = new Mage(name, age, country);
            Console.WriteLine(batas);
            Console.WriteLine("You are a mage!");
            Console.WriteLine(batas);
            Console.WriteLine("Your Data & Stats : ");
            Console.WriteLine(batas);
            mage.ShowSelf();
            className = "Mage";
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
        Console.WriteLine(batas);
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.Clear();
        // Action
        Console.WriteLine("There's Monster approaching you!");
        // warrior.attack
        bool survive = true;
        while (survive == true)
        {
            if (warrior.health < 1)
            {
                Console.Clear();
                Console.WriteLine("You are dead!");
                survive = false;
                break;
            }
            else if (monster.health < 1)
            {
                Console.Clear();
                Console.WriteLine("The Monster is Dead!!\nYou Win!");
                survive = false;
                break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(batas);
            int defence = 0;
            
            if (className == "Mage")
            {
                Console.WriteLine("Your Health : {0}", mage.health);
                Console.WriteLine("Your Mana : {0}", mage.mana);
                Console.WriteLine("Monster Health : {0}", monster.health);
                Console.WriteLine(batas);
                Console.WriteLine("What do you want to do?\n1. Attack\n2. Spell");
            }
            else
            {
                Console.WriteLine("Your Health : {0}", warrior.health);
                Console.WriteLine("Your Stamina : {0}", warrior.stamina);
                Console.WriteLine("Monster Health : {0}", monster.health);
                Console.WriteLine(batas);
                Console.WriteLine("What do you want to do?\n1. Attack\n2. Defend");
            }

            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                if (className == "Mage")
                {
                    mage.Attack(monster);
                }
                else
                {
                    warrior.Attack(monster);
                }
            }
            else if (action == 2)
            {
                if (className == "Mage")
                {
                    mage.Spell(monster);
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine(batas);
            Console.WriteLine("The monster attacks you!");
            if (className == "Mage")
            {
                monster.AttackWiz(mage);
            }
            else
            {
                monster.AttackWar(warrior, defence);
            }
            if (action == 2)
            {
                if(className == "Warrior")
                {
                    if (warrior.stamina < 25)
                    {
                        Console.WriteLine("Your stamina isn't enough to defend!");
                    }
                    else
                    {
                        Console.WriteLine("Monster tried to attack {0} damage", monster.damage);
                        defence = warrior.Defend(monster.damage);
                    }
                }
            }
            
            Console.WriteLine(batas);
            Console.WriteLine("The monster attacked you and dealt {0} damage", monster.damage - defence);
        }
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}
