namespace WindowsFormsApp3
{
    using System;

    public abstract class Elf : Helper
    {

        public virtual string ImportantTask(string weirdName) => 
            (weirdName + "Without the help of elves like {0}, the children won't get any present this Christmas.");
    }
}

