namespace WindowsFormsApp3
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    public class Child
    {
        private string[] ChildrenList = new string[20];

        public Child(string[] _ChildName, int NumberOfChildren)
        {
            for (int i = 0; i < NumberOfChildren; i++)
            {
                this.ChildrenList[i] = _ChildName[i];
            }
        }

        public string ReturnChildName(int i) => 
            this.ChildrenList[i];

        private string ChildName { get; set; }
    }
}

