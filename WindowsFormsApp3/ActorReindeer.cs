namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class ActorReindeer : Reindeer
    {


        public ActorReindeer(string _ActorReindeerName)
        {
            this.ActorReindeerName = _ActorReindeerName;
        }

        public override string ImportantTask(string weirdName) => 
            ("Actor or not, " + weirdName + " looks good pulling the sleigh in Coca-Cola ads.");

        public string ActorReindeerName { get; set; }
    }
}

