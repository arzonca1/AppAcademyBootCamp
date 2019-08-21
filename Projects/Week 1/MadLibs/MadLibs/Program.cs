using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] storyNames = new string[] {"A Day At The Zoo", "The Fun Park", "At The Arcade" };
            String[] stories = new string[] {"Today I went to the zoo. I saw a(n) {0} {1} jumping up and down in its tree.  He {2} {3} through the large tunnel that led to its {4} {5}. I got some peanuts and passed  them through the cage to a gigantic gray {6} towering above my head. Feeding that animal made  me hungry. I went to get a {7} scoop  of ice cream. It filled my stomach. Afterwards I had to {8} {9} to catch our bus.  When I got home I {10} my  mom for a {11} day at the zoo.",
                                             "Today, my fabulous  camp group went to a (an) {0} amusement park. It was a fun park with lots of cool {1} and enjoyable play structures. When we got there, my kind counselor shouted loudly, \"Everybody off the {2}.\" We all pushed out in a terrible hurry. My counselor handed out yellow tickets, and we scurried in. I was so excited! I couldn't figure out what exciting thing to do first. I saw a scary roller coaster I really liked so, I {3} ran over to get in the long line that had about {4} people in it. When I finally got on the roller coaster I was {5} . In fact I was so nervous my two knees were knocking together. This was the {6} ride I had ever been on! In about two minutes I heard the crank and grinding of the gears. That’s when the ride began! When I got to the bottom, I was a little {7} but I was proud of myself. The rest of the day went {8}. It was a(n) {9} day at the fun park.",
                                             "When I go to the arcade with my {0} there are lots of games to play. I spend lots of time there with my friends. In the game X-Men you can be different {1}. The point of the game is to {2} every robot. You also need to save people. Then you can go to the next level.  In the game Star Wars you are Luke Skywalker and you try to destroy every {3}. In a car racing/motorcycle racing game you need to beat every computerized vehicle that you are {4} against.  There are a whole lot of other cool games. When you play some games you win {5} for certain scores. Once you're done you can cash in your tickets to get a big {6}. You can save your {7} for another time. When I went to this arcade I didn't believe how much fun it would be. So far I have had a lot of fun every time I've been to this great arcade!",


            };
            String[][] keywords = new string[][] {
                new String[] { "adjective", "noun", "verb (past tense)", "adverb", "adjective", "noun", "noun", "adjective", "verb", "adverb", "verb (past tense)", "adjective" },
                new String[] { "adjective","plural noun","noun","adverb","number","past tense verb","(-est adjective)","past tense verb","adverb","adjective" },
                new String[] { "plural noun", "plural noun", "verb", "noun", "-ing verb", "plural noun", "noun", "plural noun" }

            };
            Console.WriteLine("Welcome to the Mad Libs app!");
            Console.WriteLine("Please pick story that you want to follow: ");
            for (int i = 1; i <= storyNames.Length; i++) {
                Console.WriteLine(i + ". " + storyNames[i - 1]);
            }
            int storySelected = Convert.ToInt32(Console.ReadLine());
            List<String> responses = new List<String>();
            for(int j = 0; j < keywords[storySelected].Length; j++) { 
                Console.WriteLine($"Please provide one {keywords[storySelected][j]}:");
                responses.Add(Console.ReadLine());
            }
            String[] responseArray = responses.ToArray();
            Console.WriteLine(String.Format(stories[storySelected], responseArray));
            Console.ReadKey(); 
        }
    }
}

