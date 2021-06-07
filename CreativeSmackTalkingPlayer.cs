using System;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public CreativeSmackTalkingPlayer(){
            GetTaunt();
        }
       public string GetTaunt()
        {
            Random rnd = new Random();

            string [] taunts =
                {"Ha! Your attacks are sloppy! Just like your mother!",
"Grrr I’ll enjoy eating your flesh off your bones when I‘m through with you. (It licks its lips excitedly)!",
"Our master will not be pleased if we return empty handed again.!",
"You can fight and all die or surrender and only most of you will die!!",
"My mama told me to give you one swing for free.!",
"My master said I wasn't supposed to fight people who are incompetent.!",
"Has anyone ever mistaken you for a man? Your mama said to tell you to go home for your pudding.!",
"The scars I'm going to give you will not make you look prettier.!",
"When did the guard start hiring sparring dummies?!",
"You couldn't cut a pie with a swing like that.!",
"I've seen kittens with harder swipes.!",
"Have you considered a career as a butter maid?!",
"Get ready to feel my fingers in your eyeballs! !",
"I'm gonna floss with your spine! !" ,
"I'll crack your skull open with my thumbs! !",
"I killed seven Krauts with a shovel, so one more beardy son of a bitch like you won't make a damn bit of difference!! !",
"You swing your sword like a wizard daintily twirls his rod!!",
"You ever been beaten to death with your own limbs? Hold still for a second. !",
"I'm gonna make a backscratcher outta your spine! !",
"I'm gonna rip out your guts and skip rope with them on your corpse!"};
            
            return $"{Name} says {taunts[rnd.Next(taunts.Length)]}";
        }
    }
}