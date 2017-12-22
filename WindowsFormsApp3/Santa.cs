namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class Santa : ICharacter
    {
        public Santa(string _SantaName)
        {
            this.SantaName = _SantaName;
        }

        public string EatDinner(string SantaName) => 
            (SantaName + " is eating again!");

        public string GetReward(string SantaName) => 
            (SantaName + " delivered all the presents and he received a golden star as a reward!");

        public string Sleep(string SantaName) => 
            (SantaName + "is sleeping now...to regain his/her strengths, ofc.");

        public string SantaName { get; private set; }
    }
}

