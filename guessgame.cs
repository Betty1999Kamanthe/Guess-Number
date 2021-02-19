using System;

namespace GuessGame{

    class Game{
        static void Main(String[]args){
            random r = new random();
            int win = r.Next(0,100);
            bool winGame = false;

            do{

                Console.Write("Guess a number between 0 and 100:");
                String s = Console.ReadLine;

                int i = int.Parse(s);

                if(i< win){
                    Console.WriteLine("Number too low.. Guess again!");
                }else if(i>win){
                    Console.WriteLine("Number too high.. Guess again!");
                }
                else if(i == win){
                    Console.WriteLine("You win!!")
                }

            }while(winGame == false);
        }
    }
}