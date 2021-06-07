using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public int NeedRoll {get;}
        public HumanPlayer(){
            Console.Write($"I need yhis number bad:");
            NeedRoll = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"I really need a {NeedRoll}");
        }
    }
}