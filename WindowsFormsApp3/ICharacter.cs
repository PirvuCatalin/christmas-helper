namespace WindowsFormsApp3
{
    using System;

    public interface ICharacter
    {
        string EatDinner(string weirdName);
        string GetReward(string weirdName);
        string Sleep(string weirdName);
    }
}

