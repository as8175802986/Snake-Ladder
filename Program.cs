using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    class Program
    {
         //Constants 
        //public const int NO_PLAY = 0;
        public const int LADDER = 0;
        public const int SNAKE = 1;
        public const int FINAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("**Welcome to the game of snake and ladder**");
            Console.WriteLine();
            Console.WriteLine("Double Player mode: Starting position 0 for both");  //as per UC1
            Console.WriteLine("....Game Begins....");
            Console.WriteLine();
            
            //Variables
            int position = 0;
            int position1 = 0;
            int count = 0;
            int num = 0;

            Random die = new Random();     //creatting random object from random class for player 1
            Random options = new Random();
            Random die1 = new Random();     //creatting random object from random class for player 2
            Random options1 = new Random();


            while (position < FINAL && position1 < FINAL)
            {
                count++;
                num++;
                if (num % 2 == 0)                  //To let alternative throws
                {
                    int dice = die.Next(1, 7);       //simulating the die throw 
                    //Console.WriteLine("The number on this die roll is: " + dice);
                    int opt = options.Next(0, 2);    //simulating the options
                    //options use

                    if (opt == LADDER)
                    {
                        position = position + dice;
                        num = num + 1;
                        if (position > 100)
                        {
                            //Console.WriteLine("Try Again, throw exceeded 100!");
                            position = position - dice;
                        }

                    }
                    else
                    {
                        position = position - dice;
                        //Console.WriteLine("Oops,Snake! new position-- " + position);
                    }

                    if (position < 0)
                    {
                        position = 0;
                    }
                    //Below line shows the count and postion of player 1
                    Console.WriteLine("The position after the {0} die roll is {1} for Player 1 ", count, position);
                }

                else            //This is for Player 2's Chance of Throw
                {
                    int dice1 = die1.Next(1, 7);       //simulating the die throw 
                    //Console.WriteLine("The number on this die roll is: " + dice);
                    int opt1 = options1.Next(0, 2);    //simulating the options
                    //options use
                    
                    if (opt1 == LADDER)
                    {
                        position1 = position1 + dice1;
                        num = num + 1;
                        if (position1 > 100)
                        {
                            //Console.WriteLine("Try Again, throw exceeded 100!");
                            position1 = position1 - dice1;
                        }

                    }
                    else
                    {
                        position1 = position1 - dice1;
                        //Console.WriteLine("Oops,Snake! new position-- " + position);
                    }

                    if (position1 < 0)
                    {
                        position1 = 0;
                    }
                    //Below line shows the position and count of dice for player 2
                    Console.WriteLine("The position after the {0} die roll is {1} for Player 2 ", count, position1);
                }
               
            }

            Console.WriteLine();
            //Describing the winning player
            if (position == FINAL)
            {
                Console.WriteLine("Congratulations Player 1! You have won!");
            }
            if (position1 == FINAL)
            {
                Console.WriteLine("Congratulations Player 2! you have won");
            }
        }
    }     
}
