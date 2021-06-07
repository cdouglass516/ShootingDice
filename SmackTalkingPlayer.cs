using System.Collections.Generic;
using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; }
        public string GetTaunt()
        {  
            return $"{Name} says Yo, I am so goin to win!!!";
        }

    }

}