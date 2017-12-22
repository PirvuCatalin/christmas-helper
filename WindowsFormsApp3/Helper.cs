namespace WindowsFormsApp3
{
    using System;

    public abstract class Helper : ICharacter
    {

        public string EatDinner(string weirdName) => 
            (weirdName + " is eating to restore his/her strength!");

        public string GetReward(string weirdName) => 
            (weirdName + "{0} did a good job this Christmas and (s)he received a golden star as a reward!");

        public string Sleep(string weirdName) => 
            (weirdName + "is sleeping now...to regain his/her strengths, ofc.");
    }
}

