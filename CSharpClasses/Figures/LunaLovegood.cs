using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpClasses.Figures
{
    public class LunaLovegood
    {
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public LunaLovegood()
        {
            Hair = "down";
            Head = "smiling";
            Torso = "Hogwarts sweater";
            Legs = "grey pants";
            Accessories = "wand";
        }

        public void FunFact(string person)
        {
            if (person != "Voldemort")
            {
                var funFacts = new List<string>()
                {
                    "A Wrackspurt . . . They’re invisible. They float in through your ears and make your brain go fuzzy. I thought I felt one zooming around in here.",
                    "I sleepwalk, you see. That’s why I wear shoes to bed.",
                    "The Aurors are a part of the Rotfang Conspiracy. I thought everyone knew that. They’re working from within to bring down the Ministry of Magic using a combination of Dark Magic and gum disease."
                };

                var random = new Random();
                int index = random.Next(funFacts.Count);
                Console.WriteLine(funFacts[index]);

            }
            else
            {
                Console.WriteLine("It's not wise to tell Voldemort fun facts.");
            }
        }

        public void Cheer()
        {
            if (Hair == "lion hat")
            {
                Console.WriteLine("Luna taps her lion hat and it lets out an extremely realistic roar.");
            }
            else
            {
                Console.WriteLine("Luna can't cheer without her lion hat.");
            }
        }
    }
}
