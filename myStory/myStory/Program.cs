using System;
using System.Diagnostics;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {
            // inside of one of your methods(use Main method to test this for now)
                // create a process that uses a web browser (the application)
                ProcessStartInfo theProcess = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            // use an argument for the application
            theProcess.Arguments = "https://vignette.wikia.nocookie.net/narutofanon/images/6/64/Eos.jpg/revision/latest?cb=20170717032736"; 

            // call your process
            Process.Start(theProcess);


            Console.WriteLine("My name is Phoenix, I come from the planet Xeon. I have been living on your planet for 2 years.");
            Console.ReadKey();

            ProcessStartInfo thePicture = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            // use an argument for the application
            thePicture.Arguments = "https://www.jpl.nasa.gov/spaceimages/details.php?id=PIA01464";

            // call your process
            Process.Start(thePicture);
            Console.ReadKey();
            Console.WriteLine("I left Xeon because a civil war broke out and almost all life has been destroyed.");
            Console.WriteLine("There are three others who have travelled with me: Lexi, Prodigee and Maccai. We are the Seekers.");
            Console.WriteLine("Our purpose is to find a new planet for the remaining survivors from Xeon to live.");
            Console.WriteLine("We want to live harmoniously with your people.");            
            Console.WriteLine("We are looking for others who have found your planet. We call them the Outliers.");            
            Console.WriteLine("They have come to cause chaos and conflict so your people will destroy one another.");
            Console.WriteLine("The Outliers do not believe we should live alongside one another.");
            Console.WriteLine("We have followed the Outliers to your capital city, Lunaris. We are searching for them to stop them from causing further destruction.");            
            Console.WriteLine("The leader of the Outliers, Antitheus, has been terrorizing the city. We must find him.");
            Console.ReadKey();
            ProcessStartInfo theVillain = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            // use an argument for the application
            theVillain.Arguments = "https://www.hdwallpapers.in/nero_devil_may_cry_5_4k-wallpapers.html";

            // call your process
            Process.Start(theVillain);
            Console.ReadKey();



            Console.WriteLine("Lexi: Phoenix, I spoke to some people. They have told me that Antitheus and the other Outliers are in the center of Lunaris.");
            Console.WriteLine("Phoenix: Lexi, go get Prodigee. Maccai and I will meet you in the capital city.");
            Console.WriteLine("Maccai: Phoenix, Antitheus has been using the center as a meeting place. Because of the many buildings, he has been hard to find.");
            Console.ReadKey();

            SuperHuman storyHuman = new SuperHuman("fire", 80, 25);
            storyHuman._power = "fire";
            storyHuman._force = 80;
            storyHuman._hpoints = 25;

            SuperHero storyHero = new SuperHero("wind", 100, 35, "fly");
            storyHero._opower = "fly";

            AntiHero storyAHero = new AntiHero("freeze", 8, 20, "ice");
            storyAHero._good = "ice";

            Console.WriteLine("Maccai: Phoenix, I know we can defeat Antitheus this time. You don't have to do it alone.");
            Console.WriteLine("Maccai: This time, with all of us working together, we can defeat him.");
            Console.WriteLine("Maccai: Phoenix, with your power to create {0}, the capability of Lexi to {2} water, and my ability to call the force of the {1}, we can stop Antitheus.", storyHuman._power, storyHero._power, storyAHero._power);
            Console.WriteLine("Phoenix: You are right Maccai. This is our time to find Antitheus and defeat him together. Let's go!");
            Console.ReadKey();

            Prodigee storyProdigee = new Prodigee("telepathy", 6, 15, "telepathic");
            storyProdigee._ppower = "telepathic";

            SuperVillain storyVillain = new SuperVillain("water", 8, 27, "lightening");
            storyVillain._evil = "lightening";
            Console.ReadKey();

            Console.WriteLine("Phoenix: Prodigee, use your {0} powers to find where Antitheus is.", storyProdigee._ppower);
            Console.WriteLine("Prodigee: Okay, I can see that he is making his way to the Capital Building. We are 30 minutes from there.");
            Console.WriteLine("Maccai: I will {0} ahead and try to find his exact location. Prodigee, use your {1} so you will be able to find my exact location.", storyHero._opower, storyProdigee._power);
            Console.WriteLine("Prodigee: Okay, Maccai, I will.");
            Console.ReadKey();

            Console.WriteLine("Antitheus was in the center of the city. He was destroying the city.");
            Console.WriteLine("The {0} strikes he was throwing were causing buildings to start on fire.", storyVillain._evil);
            Console.WriteLine("The people are running around trying to find cover so they don't get hit.");
            Console.WriteLine("The Outliers are shooting the people fleeing from the lightening strikes.");
            Console.ReadKey();

            Console.WriteLine("Maccai could hear the screaming from the people as she was flying towards the Capital Building, she knew she must be close.");
            Console.WriteLine("As Maccai flew in closer, she flew down straight into an Outlier.");
            Console.WriteLine("When Maccai connected with the Outlier, she knocked him down so hard.");
            Console.WriteLine("With the combination of velocity and speed, Maccai went full force at {0} mph.", storyHero._force);
            Console.WriteLine("The blow was so hard, he was unable to recover from it.");
            Console.ReadKey();

            Console.WriteLine("Maccai could see Antitheus. He was intent on destroying the city.");
            Console.WriteLine("Prodigee, Lexi, and Phoenix had reached the city.");
            Console.WriteLine("Prodigee was sending messages {0}ally to Antitheus to try to distract his mind and disrupt his concentration.");
            Console.WriteLine("Lexi was creating a blacket of {0} on the buildings so when the {1} struck it wouldn't do any damage.", storyAHero._good ,storyVillain._evil);
            Console.WriteLine("Phoenix was waiting for the moment that Antitheus had been so distracted by Prodigee that they could all focus on him and destroy him with all their powers.");
            Console.ReadKey();

            Console.WriteLine("Antitheus was so distracted from the disruption of Prodigee in his mind, he was grabbing his head.");
            Console.WriteLine("All of a sudden the {0} was blowing so heavy he couldn't see.", storyHero._power);
            Console.WriteLine("Maccai: Phoenix, Prodigee and I have distracted him enough. You can now use {0} to destroy him.", storyHuman._power);
            Console.WriteLine("Phoenix conjured up all her force, and bombarded Antitheus will fireballs.");
            Console.WriteLine("Phoenix placed her hands over her head and with a force of {0}, she was able to create a huge fireball.", storyHuman._force);
            Console.ReadKey();

            ProcessStartInfo theFire = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            // use an argument for the application
            theFire.Arguments = "https://www.youtube.com/watch?v=rHENXKVwPTg";

            // call your process
            Process.Start(theFire);
            Console.ReadKey();
            Console.WriteLine("She threw it at Antitheus. He couldn't withstand the blast. The damage was four times {0}, 100.", storyHuman._hpoints);
            Console.ReadKey();

            Console.WriteLine("Antitheus had fallen.");
            Console.WriteLine("Lexi, Maccai, Prodigee and Phoenix rejoiced because he had fallen.");
            Console.WriteLine("Phoenix spoke to the people in the capital and let them know that there wasn't anything else to worry about.");
            Console.WriteLine("The remaining Outliers fled the planiet.");
            Console.ReadKey();

            ProcessStartInfo theEnd = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");

            // use an argument for the application
            theEnd.Arguments = "https://pixabay.com/en/phoenix-bird-legendary-mythical-1301887/";

            // call your process
            Process.Start(theEnd);
            Console.ReadKey();


        }   
    }
}
