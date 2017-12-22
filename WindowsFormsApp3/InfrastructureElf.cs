namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class InfrastructureElf : ITElf
    {
        private string[] PresentsList;

        public InfrastructureElf(string weirdName)
        {
            this.PresentsList = new string[20];
            this.InfrastructureElfName = weirdName;
        }

        public InfrastructureElf(string weirdName, string[] _PresentsList, int _NumberOfPresents)
        {
            this.PresentsList = new string[20];
            this.InfrastructureElfName = weirdName;
            this.NumberOfPresents = _NumberOfPresents;
            for (int i = 0; i < _NumberOfPresents; i++)
            {
                this.PresentsList[i] = _PresentsList[i];
            }
            string str = this.PresentsList[1];
            this.PresentsList[1] = this.PresentsList[3];
            this.PresentsList[3] = str;
            str = this.PresentsList[2];
            this.PresentsList[2] = this.PresentsList[4];
            this.PresentsList[4] = str;
            str = this.PresentsList[5];
            this.PresentsList[5] = this.PresentsList[6];
            this.PresentsList[6] = str;
            str = this.PresentsList[12];
            this.PresentsList[12] = this.PresentsList[9];
            this.PresentsList[9] = str;
            str = this.PresentsList[14];
            this.PresentsList[14] = this.PresentsList[0x10];
            this.PresentsList[0x10] = str;
            str = this.PresentsList[0x11];
            this.PresentsList[0x11] = this.PresentsList[0x13];
            this.PresentsList[0x13] = str;
        }

        public override string ImportantTask(string weirdName) => 
            (weirdName + " is reading a letter from a child. Let him read carefully, it may be yours!");

        public string ReturnNewPresentList(int i) => 
            this.PresentsList[i];

        public string InfrastructureElfName { get; set; }

        private int NumberOfPresents { get; set; }
    }
}

