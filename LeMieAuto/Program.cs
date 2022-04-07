
using MieClassi;

Auto LaMiaMacchina = new Auto("Audi", "RS3", 2020, "CK0480ZT", "blu");




/*
Auto LaMacchinaDiAntonio = new Auto();

LaMacchinaDiAntonio.colore = "rosso";
LaMacchinaDiAntonio.marca = "Ferrari";
LaMacchinaDiAntonio.modello = "California";
LaMacchinaDiAntonio.annoDiProduzione = 2018;
LaMacchinaDiAntonio.targa = "ZT9600VD";
*/




















Console.WriteLine($"La marca della mia auto è {LaMiaMacchina.marca}");

Console.WriteLine($"La mia auto è accesa ? {LaMiaMacchina.accesa}");
LaMiaMacchina.Accenditi();
Console.WriteLine($"La mia auto è accesa ? {LaMiaMacchina.accesa}");

LaMiaMacchina.Spegniti();
Console.WriteLine($"La mia auto è accesa ? {LaMiaMacchina.accesa}");

LaMiaMacchina.RiverniciaAuto("verde");
Console.WriteLine($"Il colore della mia macchina è {LaMiaMacchina.colore}");

/*
Console.WriteLine($"La marca dell'auto di Antonio è {LaMacchinaDiAntonio.marca}");
*/

