using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThursdayChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThursdayChallenge()
        {
            string firstName = "Anna";
            string lastName = "Williamson";
            string age = "20";
        }
        [TestMethod]
        public void ThursdayChallenge2()
        {
            string[] favShows = { "Adventure Time", "Shameless", "Black Mirror", "Bob Ross" };
        }
        [TestMethod]
        public void ThursdayChallenge3()
        {
            //--come back to this one
            int numOne = 10;
            if(numOne >= 10)
            {
                Console.WriteLine("you got a lot of sleep!");
            }
            else if(numOne > 8)
            {
                Console.WriteLine("You should be well rested!");
            }
            else if(numOne > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("get some sleep!");
            }
        }
        [TestMethod]
        public void ThursdayChallenges4()
        {
            //--time and date list
            
           
            DateTime dt = new DateTime();

        }
        [TestMethod]
        public void ThursdayChallenges5()
        {
            //--switchcase
            Console.WriteLine("How are you today! 1 = great, 2 = good, 3 = okay, 4 = bad 5 = :(");
            int mood = 50;
            switch (mood)
            {
                case 1:
                    Console.WriteLine("HOORAY!!");
                    break;
                case 2:
                    Console.WriteLine("Hope your day gets even better!");
                    break;
                case 3:
                    Console.WriteLine("Hope your day gets a little better!");
                    break;
                case 4:
                    Console.WriteLine("let me give you a hug");
                    break;
                case 5:
                    Console.WriteLine("oh no! 10 hugs for you");
                    break;
            }
        }
        [TestMethod]
        public void ThursdayChallenges6()
        {
            int numOne = 20;
            int numTwo = 7;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");


        }
        [TestMethod]
        public void ThursdayChallenges7()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
