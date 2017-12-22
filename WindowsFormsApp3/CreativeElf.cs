namespace WindowsFormsApp3
{
    using System;

    public abstract class CreativeElf : Elf
    {

        public override string ImportantTask(string weirdName) => 
            ("Creative elves are dreamers, each of them has a list of presents they can make. Don't interrupt " + weirdName + ", (s)he has a new idea!");
    }
}

