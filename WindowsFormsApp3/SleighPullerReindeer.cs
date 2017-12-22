namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class SleighPullerReindeer : Reindeer
    {

        public SleighPullerReindeer(string _SleighPullerReindeerName)
        {
            this.SleighPullerReindeerName = _SleighPullerReindeerName;
        }

        public override string ImportantTask(string weirdName) => 
            (weirdName + " is working out right now so he can easily deliver all the presents.");

        public string SleighPullerReindeerName { get; set; }
    }
}

