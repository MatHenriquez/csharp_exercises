/*
 * Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:
 * Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
 * El héroe y el monstruo comenzarán con 10 puntos de salud.
 * Todos los ataques serán un valor comprendido entre 1 y 10.
 * El héroe atacará primero.
 * Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
 * Si la salud del monstruo es mayor que 0, puede atacar al héroe.
 * Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
 * Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
 * Imprima el ganador.
 */

// My solution

int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();

do
{
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;

    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        continue;
    }

    int monsterAttack = random.Next(1, 11); 
    heroHealth -= monsterAttack;

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health");

    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        continue;
    }
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine("Game Over");

// Microsoft's solution

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");