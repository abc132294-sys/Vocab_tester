Dictionary<string, string> vokabeln = new Dictionary<string, string>();
List<string> vokabelnList = new List<string>();

AddVokabel();

void AddVokabel()
{
    while (true)
    {
        Console.WriteLine("Geben Sie die Vokabel ein (nicht Deutsch) [n] um die Abfrage zu starten: ");
        var a = Console.ReadLine();
        if (a != null && a != "n")
        {
            Console.WriteLine("Geben Sie die Übersetzung ein (Deutsch): ");
            var b = Console.ReadLine();
            vokabeln.Add(a, b);
        }
        else break;
    }

    Console.Clear();
}


while (true)
{
    vokabelnList.Clear();
    while (vokabelnList.Count != vokabeln.Count)
    {
        while(true)
        {
            var random = new Random();
            var index = random.Next(vokabeln.Count);
            var vokabel = vokabeln.ElementAt(index);

            for (int i = 0; i < vokabelnList.Count; i++)
            {
                if (vokabelnList[i].ToString() == vokabel.ToString()) break;
            }

            Console.WriteLine($"Was ist die Übersetzung von {vokabel.Key}?  ['$'] um neue Vokablen hinzuzufügen... ['$clear'] für Console.Clear()");
            var antwort = Console.ReadLine();
            if(antwort == "$")
            {
                AddVokabel();
            }
            if (antwort == "$clear") Console.Clear();
            if (antwort == vokabel.Value)
            {
                vokabelnList.Add(antwort);
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine($"Falsch! Die richtige Antwort ist: {vokabel.Value}");
            }
        }
    }
}