namespace WindowsFormsApp3
{
    using System;

    public abstract class Reindeer : Helper
    {

        public virtual string ImportantTask(string weirdName) => 
            ("Reindeers are the most loved animals during this time. The children rely on " + weirdName + " to bring their presents.");
    }
}

