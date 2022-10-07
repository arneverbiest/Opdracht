using OpdrachtQFrame;
using System.Globalization;


int idtalk = 0;
string end = "y";
string nameTalk;
int durationTalk;
var talks = new List<Talk>();
int total = 0;

Console.WriteLine("Welkom bij onze applicatie.");
while (end != "n")
{
    ++idtalk;
    Console.WriteLine("welke talk zou u willen toevoegen?");
    nameTalk = Console.ReadLine();
    Console.WriteLine("hoelang zou deze talk duren?");
    durationTalk = Int32.Parse(Console.ReadLine());
    talks.Add(new Talk() { IdTalk = idtalk, NameTalk = nameTalk, DurationTalk = durationTalk });
    total += durationTalk;
    Console.WriteLine(total);
    if (total > 180)
    {
        
        Console.WriteLine("het getal is te groot voor ochtendsessie");

    }
    Console.WriteLine("wilt u nog een talk toevoegen?(y/n)");
    end = Console.ReadLine();
    Console.Clear();
}
for (int i = 0; i < talks.Count; i++)
{
 
    Console.WriteLine($"{talks[i].NameTalk} heeft het id {talks[i].IdTalk} en duurt het {talks[i].DurationTalk}");


}
{

}