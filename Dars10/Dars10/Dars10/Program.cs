


using Dars10;

#region
/*static[] SS(string s1,string s2)
{
    List<string> words =new List<string>();
    words.AddRange(s1.Split(' '));
    words.AddRange(s2.Split(' '));

    List<string> ss = new List<string>();
     foreach(string word in words)
    {
        var counter = words.Count(x => x == word);
        if(counter == 1)
        {
            ss.Add(word);
        }
    }
    return ss.ToArray();
}*/
#endregion


#region Parta clas


Parta parta1=new Parta();

parta1.Eni       =  int.Parse(Console.ReadLine());
parta1.Uzunlig   =  int.Parse(Console.ReadLine());
parta1.Balantlik =  int.Parse(Console.ReadLine());
parta1.Rangi     =  Console.ReadLine();
parta1.Qalinligi =  int.Parse(Console.ReadLine());

parta1.PartaYuzasi();
parta1.PartaKub();

#endregion

#region TV

var tv = new TV();

tv.TvMadel ="Artel";
tv.TvDyumi = 32.0;
tv.TvHz = 120;
tv.TvColor = "Blac";
tv.TvWifi = true;


#endregion

#region Telefon

var telefon = new Telefon();

telefon.TelMadel = "Samsung";
telefon.TelDiyum = 7.2;
telefon.TelQaling = 1.8;
telefon.TelDisplay = "OLD";
telefon.TelXotiras = 256;

#endregion

#region Gilam

var gil = new Gilam();

gil.GilUzunlig = 800;
gil.GilEni = 300;
gil.GilQalinlik = 3;
gil.GilRang = "Oq";
gil.GilShakl = "To'g'ri to'rburchak ";
#endregion

