namespace WindowsFormsApp3
{
    using System;

    public abstract class ITElf : Elf
    {

        public override string ImportantTask(string weirdName) => 
            ("IT elves like " + weirdName + " have a lot of work to do, Santa even give them access to he's computers!");
    }
}

