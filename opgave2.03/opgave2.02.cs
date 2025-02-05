// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("antal aviser");

int aviser = int.Parse(Console.ReadLine());

if (aviser > 50)

{

    Console.WriteLine("Du skal bruge" + " " + (aviser / 50) + " " + "og" + " " + "et restbundt med" + " " + aviser % 50 + " " + "aviser");
}

else Console.WriteLine("Du lever ikke op til de krav der forventes");

