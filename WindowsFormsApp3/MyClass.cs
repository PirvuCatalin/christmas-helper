namespace WindowsFormsApp3
{
    using System;

    public class MyClass
    {
        public void MyMethod(Form1 F, int c, string Present)
        {
            int num;
            int num2;
            int num4;
            int index = 0;
            string[] strArray = new string[20];
            string[] strArray2 = new string[20];
            string[] childrenList = new string[20];
            Santa santa = new Santa("Mosneagul");
            GiftMakerElf[] elfArray = new GiftMakerElf[3];
            string[] textArray1 = new string[] { "Bicicleta roz", "Bicicleta albastra", "Bicicleta roz bonbon", "Ochelari de soare" };
            elfArray[0] = new GiftMakerElf("Ionia", 4, textArray1);
            string[] textArray2 = new string[] { "Masina alba de jucarie", "Tractor", "Ursulet de plus", "Ursulet de plus negru" };
            elfArray[1] = new GiftMakerElf("Sonia", 4, textArray2);
            string[] textArray3 = new string[] { "Bicicleta albastra de teren", "Masina de jucarie", "Tractoras" };
            elfArray[2] = new GiftMakerElf("Monia", 3, textArray3);
            CookElf[] elfArray2 = new CookElf[3];
            string[] textArray4 = new string[] { "Tort cu ciocolata", "Tort cu ciocolata neagra", "Tortulet cu arahide" };
            elfArray2[0] = new CookElf("Bucatarul", 3, textArray4);
            string[] textArray5 = new string[] { "Prajiturici", "BakeRolls", "Negresa", "Negresa cu stafide" };
            elfArray2[1] = new CookElf("Detoate", 4, textArray5);
            string[] textArray6 = new string[] { "Salata de fructe la pachet", "Dulceata de vinete" };
            elfArray2[2] = new CookElf("Carina", 2, textArray6);
            for (num = 0; num < 3; num++)
            {
                num4 = elfArray[num].ReturnNumberOfItems();
                num2 = 0;
                while (num2 < num4)
                {
                    strArray[index] = elfArray[num].ReturnItems(num2);
                    index++;
                    num2++;
                }
            }
            for (num = 0; num < 3; num++)
            {
                num4 = elfArray2[num].ReturnNumberOfItems();
                for (num2 = 0; num2 < num4; num2++)
                {
                    strArray[index] = elfArray2[num].ReturnItems(num2);
                    index++;
                }
            }
            int num5 = index;
            InfrastructureElf elf = new InfrastructureElf("Catalinovici", strArray, index);
            InfrastructureElf elf2 = new InfrastructureElf("Andreiovici");
            InfrastructureElf elf3 = new InfrastructureElf("Dragosovici");
            for (num = 0; num < num5; num++)
            {
                strArray2[num] = elf.ReturnNewPresentList(num);
            }
            AdminElf elf4 = new AdminElf("Catalinovschi", strArray2, num5);
            AdminElf elf5 = new AdminElf("Matache");
            AdminElf elf6 = new AdminElf("Popa");
            for (num = 0; num < num5; num++)
            {
                strArray2[num] = elf4.ReturnFinalPresentList(num);
            }
            string[] textArray7 = new string[] { 
                "Ionelus", "Costelus", "Maricica", "Eduardo", "Dragos", "Daniel", "Carina", "Ionut", "Adriana", "Catalin", "Diana", "Raluca", "Roberta", "Rebeca", "Dori", "Silviu",
                "Antohi", "Andrei", "Isabela", "Sorin"
            };
            Child child = new Child(textArray7, num5);
            for (num = 0; num < num5; num++)
            {
                childrenList[num] = child.ReturnChildName(num);
            }
            SleighPullerReindeer reindeer = new SleighPullerReindeer("Marcelus");
            SleighPullerReindeer reindeer2 = new SleighPullerReindeer("Ciprian");
            SleighPullerReindeer reindeer3 = new SleighPullerReindeer("Dorel");
            ActorReindeer reindeer4 = new ActorReindeer("Mihai Traistariu");
            ActorReindeer reindeer5 = new ActorReindeer("Dorian Popa");
            if (c == 1)
            {
                for (int i = 0; i < num5; i++)
                {
                    F.AllItemsList(strArray2, childrenList, i);
                }
            }
            else if (c == 2)
            {
                for (num = 0; num < 3; num++)
                {
                    F.AddTextWait(elfArray[num].ImportantTask(elfArray[num].GiftMakerName));
                    F.AddTextWait(elfArray2[num].ImportantTask(elfArray2[num].CookElfName));
                }
                F.AddTextWait(elf.ImportantTask(elf.InfrastructureElfName));
                F.AddTextWait(elf2.ImportantTask(elf2.InfrastructureElfName));
                F.AddTextWait(elf3.ImportantTask(elf3.InfrastructureElfName));
                F.AddTextWait(elf4.ImportantTask(elf4.AdminElfName));
                F.AddTextWait(elf5.ImportantTask(elf5.AdminElfName));
                F.AddTextWait(elf6.ImportantTask(elf6.AdminElfName));
                F.AddTextWait(reindeer.ImportantTask(reindeer.SleighPullerReindeerName));
                F.AddTextWait(reindeer2.ImportantTask(reindeer2.SleighPullerReindeerName));
                F.AddTextWait(reindeer3.ImportantTask(reindeer3.SleighPullerReindeerName));
                F.AddTextWait(reindeer4.ImportantTask(reindeer4.ActorReindeerName));
                F.AddTextWait(reindeer5.ImportantTask(reindeer5.ActorReindeerName));
            }
            else if (c == 3)
            {
                F.UpdateSuggestions(strArray2);
            }
            else if (c == 4)
            {
                for (num = 0; num < num5; num++)
                {
                    if (strArray2[num] == Present)
                    {
                        F.AddText("This gift belongs to ---> " + childrenList[num]);
                    }
                }
            }
            else if (c == 5)
            {
                F.AddTextWait("This is the most important moment.");
                F.AddTextWait("Everything must be perfect or...");
                F.AddTextWait("the presents won't be delivered as they should be!");
                F.AddTextWait("The following elves crafted the toys:");
                for (num = 0; num < 3; num++)
                {
                    F.AddTextWait(elfArray[num].GiftMakerName);
                }
                F.AddTextWait("The following elves cooked the sweets:");
                for (num = 0; num < 3; num++)
                {
                    F.AddTextWait(elfArray2[num].CookElfName);
                }
                F.AddTextWait("IT elves did a brilliant job with the application and " + santa.SantaName);
                F.AddTextWait("is receiving a copy of it to make his job easier");
                F.AddTextWait("We have to thank the following elves for reading every single letter:");
                F.AddTextWait(elf4.AdminElfName);
                F.AddTextWait(elf5.AdminElfName);
                F.AddTextWait(elf6.AdminElfName);
                F.AddTextWait("The infrastructure elves...");
                F.AddTextWait("they prefer to keep their identity private.");
                F.AddTextWait("(they are the ones that decided if a child should receive a present or not)");
                F.AddTextWait("Now we're good to go. All of the gifts are in the sleigh!");
                F.AddTextWait("Don't forget about the reindeers, " + santa.SantaName + "e!");
                F.AddTextWait("Here they are: ");
                F.AddTextWait(reindeer.SleighPullerReindeerName);
                F.AddTextWait(reindeer2.SleighPullerReindeerName);
                F.AddTextWait(reindeer3.SleighPullerReindeerName);
                F.AddTextWait("\"Actor reindeers? Kidding me?\" - NO!. They spent such a long time performing in those ads!");
                F.AddTextWait(reindeer4.ActorReindeerName);
                F.AddTextWait(reindeer5.ActorReindeerName);
                F.AddTextWait(".................................");
                F.AddTextWait(".");
                F.AddTextWait("And that's how the presents have been prepared.");
                F.AddTextWait("What's next? That's a mistery that I shouldn't tell you.");
                F.AddTextWait("Oh! Almost forgot.");
                F.AddTextWait("Everyone got what they wanted. What happened with the people from the North Pole?");
                F.AddTextWait("Well, everyone got a golden star as a reward (not so expensive cause I'm almost out of code lines)");
                F.AddTextWait("Merry Christmas!");
            }
        }
    }
}

