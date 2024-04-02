// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Mr. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
//= Char.Parse tähendab seda, et muudab info kohe char kujule

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.  {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
//kui if plok n läbi tehtud ja kood on ära teinud, siis kood enam vahemälus ei eksisteeri
//"'" ülakomad on reserveeritud char'dele ja jutumärgid on stringidele
//else if hoiab ära selle, et peale positiivse vastuse saamist ta teeb ka järgmised kontrollid
