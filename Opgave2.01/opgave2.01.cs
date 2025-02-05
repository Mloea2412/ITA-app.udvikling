// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Opgave 2.01 Sove opgave

// Lav et nyt konsol-projekt
// I main-metoden skal du gøre følgende:
// Spørge efter brugerens navn
// Gemme dette navn i en variabel
// Spørge hvor mange timer brugeren har sovet i nat
// Gemme tallet i en variabel
// Hvis brugeren har sovet mindre end 8 timer
// Udskriv at brugeren må være træt (brug brugerens navn i sætningen)
// Ellers
// Udskriv at brugeren ser veludhvilet ud (brug brugerens navn i sætningen)


/*Console.WriteLine("Hej Hej");
string velkomst = "Velkommen til app udvikling";
Console.WriteLine(velkomst);
Console.WriteLine("Skriv dit navn");
string navn = Console.ReadLine();
Console.WriteLine("Hej " + navn);
// min kommentar....
Console.Write("5* 12 =");
Console.WriteLine(5 * 12);

*/


Console.WriteLine("Hvad er dit navn?");

string navn = Console.ReadLine();

Console.WriteLine("Hvor mange timers søvn har du fået?"); int søvn = int.Parse(Console.ReadLine());
// min kommentar....

if (søvn < 8)

{
    Console.WriteLine("Du må være træt" + " " + navn);
}

else
{
    Console.WriteLine("Du må være udhvilet" + " " + navn);
};
