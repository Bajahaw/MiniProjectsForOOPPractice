using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int numOfcompetitors=0;
        Dictionary<string,List<string>> sportInfo = new Dictionary<string, List<string>>();
        do
        {
            Console.WriteLine("Enter the name of competitor: OR[ press enter to exit]");
            string name = Console.ReadLine().ToLower();
            if (String.IsNullOrEmpty(name))
                break;
            ICollection<List<string>> values = sportInfo.Values;
            if (CompetitorFound(sportInfo, name))
                Console.WriteLine($"this competitor already exist!!");
            else
            {
                numOfcompetitors++;

                Console.WriteLine("Enter the sport he involved in:");
                string involvingSports = Console.ReadLine().ToLower();
                if (String.IsNullOrEmpty(involvingSports))
                      Console.WriteLine("Invalid Expction : empyt input");
                    // check if the sport type allready exist
                    if (sportInfo.ContainsKey(involvingSports.ToLower()))
                    {
                        sportInfo[involvingSports.ToLower()].Add(name);
                    }
                    else
                        sportInfo.Add(involvingSports.ToLower(), new List<string>() { name });
                
            }
        } while (true);
        Console.WriteLine($"Inputs                                         outputs");
        Console.WriteLine($"{numOfcompetitors} competitors                            {sportInfo.Count} sport types");
        for (int i = 0; i < sportInfo.Count; i++)
        {
            Console.WriteLine($"{sportInfo.Keys.ElementAt(i)}:       {String.Join(',',sportInfo.Values.ElementAt(i))}") ;
        }
       
    }

    public static bool CompetitorFound(Dictionary<String, List<string>> dic,string name) 
    {
        ICollection<List<string>> values = dic.Values;
        foreach (var list in values) 
        {
            if (list.Contains(name))
                return true;
            
        }
        return false;
    }
}