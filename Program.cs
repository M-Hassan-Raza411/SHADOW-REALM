Console.WriteLine("================================");
Console.WriteLine("       SHADOW REALM");
Console.WriteLine("================================");

Console.Write("Enter your character name: ");

string playerName = Console.ReadLine();

Console.WriteLine("enter ur age");

int playerAge=Convert.ToInt32(Console.ReadLine());

int health = 100;
int attack = 15;
int defense = 5;
int level = 1;
int xp = 0;


Console.WriteLine("\nYour character has been created! You can change player classes later ");
Console.WriteLine("Name: " + playerName);
Console.WriteLine("Age: " + playerAge);
Console.WriteLine("Health: " + health);
Console.WriteLine("Attack: " + attack);
Console.WriteLine("Defense: " + defense);
Console.WriteLine("Level: " + level);
Console.WriteLine("XP: " + xp);

Console.WriteLine();



Console.WriteLine("Choose your class:");
Console.WriteLine("1. Warrior");
Console.WriteLine("2. Assassin");
Console.WriteLine("3. Mage");
Console.WriteLine();

Console.Write("Your choice: ");

string choice = Console.ReadLine();

string className="";

if (choice == "1")
{
    health = 150;
    attack = 20;
    defense = 10;
    className = "Warrior";
}
else if (choice == "2")
{
    health = 90;
    attack = 30;
    defense = 5;
    className = "Assassin";
}
else if (choice == "3")
{
    health = 100;
    attack = 25;
    defense = 7;
    className = "Mage";
}
else
{
    Console.WriteLine("Invalid Choice use Choose between 1 And 3 ");
    return;
}

Console.WriteLine("\nYour character has been created!");
Console.WriteLine("Name: " + playerName);
Console.WriteLine("Age: " + playerAge);
Console.WriteLine("Health: " + health);
Console.WriteLine("Attack: " + attack);
Console.WriteLine("Defense: " + defense);
Console.WriteLine("Class: " + className);
Console.WriteLine();

int goblinHealth = 50;
int goblinAttack = 10;
int playerDamage = attack - 5; // Player's damage to goblin
bool isDefending = false;
while (goblinHealth > 0 && health > 0)
{
    Console.WriteLine("A wild goblin appears!");
    Console.WriteLine("Goblin Health: " + goblinHealth);
    Console.WriteLine("Your Health: " + health);
    Console.WriteLine("Choose your action:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Defend");
    Console.WriteLine();

    string action = Console.ReadLine();

    if (action == "1")
    {
        goblinHealth -= playerDamage;
        Console.WriteLine("You attack the goblin for " + playerDamage + " damage!");
    }
    else if (action == "2")
    {   isDefending = true;
        int damageTaken = isDefending ? goblinAttack / 2 : 0;
        if (damageTaken < 0) damageTaken = 0;
        health -= damageTaken;
        Console.WriteLine("You defend against the goblin's attack and take " + damageTaken + " damage!");
    }
    else
    {
        Console.WriteLine("Invalid action! The goblin attacks you!");
        health -= goblinAttack;
    }

    if (goblinHealth > 0)
    {
        int damageTaken = isDefending ? 0 : goblinAttack - defense;
        if (damageTaken < 0) damageTaken = 0;
        health -= damageTaken;
        Console.WriteLine("The goblin attacks you for " + damageTaken + " damage!");
    }

    Console.WriteLine();
}
if (health <= 0)
{
    Console.WriteLine("You have been defeated by the goblin!");
}
else
{
    Console.WriteLine("You have defeated the goblin!");
    xp += 20;
    Console.WriteLine("You gained 20 XP! Total XP: " + xp);
}