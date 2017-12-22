namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class AdminElf : ITElf
    {
        private string[] PresentsList;

        public AdminElf(string weirdName)
        {
            this.PresentsList = new string[20];
            this.AdminElfName = weirdName;
        }

        public AdminElf(string weirdName, string[] _PresentsList, int _NumberOfPresents)
        {
            this.PresentsList = new string[20];
            this.AdminElfName = weirdName;
            this.NumberOfPresents = _NumberOfPresents;
            for (int i = 0; i < _NumberOfPresents; i++)
            {
                if (((i == 2) || (i == 7)) || (i == 8))
                {
                    this.PresentsList[i] = "Carbuni";
                }
                else
                {
                    this.PresentsList[i] = _PresentsList[i];
                }
            }
        }

        public override string ImportantTask(string weirdName) => 
            (weirdName + " with his other admin friends know if a child has been bad or good. They are still watching!");

        public string ReturnFinalPresentList(int i) => 
            this.PresentsList[i];

        public string AdminElfName { get; set; }

        private int NumberOfPresents { get; set; }
    }
}

