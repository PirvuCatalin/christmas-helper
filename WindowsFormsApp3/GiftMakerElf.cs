namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class GiftMakerElf : CreativeElf
    {
        public string[] ItemList = new string[10];

        public GiftMakerElf(string _GiftMakerName, int _NumberOfItems, string[] _ItemList)
        {
            this.GiftMakerName = _GiftMakerName;
            this.NumberOfItems = _NumberOfItems;
            for (int i = 0; i < _NumberOfItems; i++)
            {
                this.ItemList[i] = _ItemList[i];
            }
        }

        public override string ImportantTask(string weirdName) => 
            (weirdName + " is crafting some cool toys, but only for the good children!");

        public void PrintItemList()
        {
            for (int i = 0; i < this.NumberOfItems; i++)
            {
                Console.WriteLine(this.ItemList[i]);
            }
        }

        public string ReturnItems(int i) => 
            this.ItemList[i];

        public int ReturnNumberOfItems() => 
            this.NumberOfItems;

        public string GiftMakerName { get; set; }

        public int NumberOfItems { get; set; }
    }
}

