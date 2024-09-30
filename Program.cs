using System;
using System.Collections.Generic;
using TextFile;

namespace assign2;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            TextFileReader reader = new("input.txt");
            if (reader == null)
            {
                throw new Exception("the file is empty");
            }
            List<Animals> animalsList = new List<Animals>();
            animalsList = Animals.create(ref reader);
            List<char> moods = new List<char>();
            moods = Animals.create2(ref reader);
            foreach (char mood in moods)
            {
                Cathy cathy;
                if (mood == 'g')
                {
                    cathy = Good.Instance();
                }
                else if (mood == 'o')
                {
                    cathy = Ordinary.Instance();
                }
                else if (mood == 'b')
                {
                    cathy = Bad.Instance();
                }
                else
                {
                    throw new InvalidOperationException();
                }


                foreach (Animals animals in animalsList)
                {
                    animals.theirExhib(cathy);

                    if (animalsList.All(a => !a.alive() || a.Exhib() >= 5))
                    {
                        cathy.increseMood();
                    }
                }

            }
            List<string> stillLive = new List<string>();
            int minExhibit = animalsList.Where(a => a.alive()).Min(a => a.Exhib());

            
                foreach (Animals a in animalsList)
                {
                    if (a.alive() && a.Exhib() == minExhibit)
                    {
                        stillLive.Add(a.Name());
                    }

                }
            
            for (int i = 0; i < stillLive.Count; i++)
            {
                Console.WriteLine(stillLive[i]);

            }
            Console.ReadLine();
        }
        catch (Exception) { }

          
    }

 

}

