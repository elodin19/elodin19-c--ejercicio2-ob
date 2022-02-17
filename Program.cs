//Ejercicio 1 - Variables
Console.Write("What's your name? ");
string name = Console.ReadLine();

Console.Write("What's your last name, " + name + "? ");
string lastName = Console.ReadLine();

Console.Write("How old are you, " + name + " " + lastName + "? ");
string age = Console.ReadLine();
int iAge = Convert.ToInt32(age);

Console.Write("Can you code? (y or n) ");
string code = Console.ReadLine();
bool bCode = false;

if (code == "y"){
    bCode = true;
}


//Ejercicio 2 - Tipos

//Describing a car
int doors = 4, wheels = 4;
string itv = "ABS21493812", brand = "ford";

//Describing a table
int weight = 30;
float lenght = 2.5f;
string material = "wood", color = "brown";

//Ejercicio 3

/*

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false) */

char character = 'a';

Console.WriteLine("Is 30 bigger than 18? " + (30 > 18));
Console.WriteLine("Is 'a' the value of the variable character? " + (character == 'a'));
Console.WriteLine("Are the two conditions true? " + ((0 == 0 ) && (0 != 1)));
Console.WriteLine("Is just one condition true? " + ((0 == 0 ) && (0 != 1)));