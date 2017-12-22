namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class CookElf : CreativeElf
    {
        private string[] SweetsList = new string[10];

        public CookElf(string _CookElf, int _NumberOfSweets, string[] _SweetsList)
        {
            this.CookElfName = _CookElf;
            this.NumberOfSweets = _NumberOfSweets;
            for (int i = 0; i < _NumberOfSweets; i++)
            {
                this.SweetsList[i] = _SweetsList[i];
            }
        }

        public override string ImportantTask(string weirdName) => 
            (weirdName + " is preparing the most delicious sweets for the good children!");

        public void PrintSweetsList()
        {
            for (int i = 0; i < this.NumberOfSweets; i++)
            {
                Console.WriteLine(this.SweetsList[i]);
            }
        }

        public string ReturnItems(int i) => 
            this.SweetsList[i];

        public int ReturnNumberOfItems() => 
            this.NumberOfSweets;

        public string CookElfName { get; private set; }

        public int NumberOfSweets { get; private set; }
    }
}

