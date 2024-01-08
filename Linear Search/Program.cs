using GA_LinearSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {

        //Arrays
        static string[] cardNames;
        static string[] cardRarities;
        static MagicCard[] cards;

        static void Main(string[] args)
        {
            //Add data to the arrays
            MyPreload();

            Console.WriteLine("Test of ContainsCardName. Should be True then False.");
            Console.WriteLine(ContainsCardName(cardNames, "Omnath, Locus of Rage"));//True
            Console.WriteLine(ContainsCardName(cardNames, "Divination"));//False

            Console.WriteLine("Test of FirstIndexOfRarity. Should be 1, 6 then -1.");
            Console.WriteLine(FirstIndexOfRarity(cardRarities, "Common"));//1
            Console.WriteLine(FirstIndexOfRarity(cardRarities, "Uncommon"));//6
            Console.WriteLine(FirstIndexOfRarity(cardRarities, "Legendary"));//-1

            Console.WriteLine("Test of AllIndeciesOfRarity. Should be 2, 4 then 0.");
            Console.WriteLine(AllIndeciesOfRarity(cardRarities, "Common").Count);//2
            Console.WriteLine(AllIndeciesOfRarity(cardRarities, "Rare").Count);//4
            Console.WriteLine(AllIndeciesOfRarity(cardRarities, "Legendary").Count);//0

            Console.WriteLine("Test of AllCardsOfCMC. Should be 3, Increasing Vengeance, Thought Vessel, and Fall of the Hammer all have cmc 2, then 0.");
            
            List<MagicCard> tempResult = AllCardsOfCMC(cards, 2);//Cards with cmc 2
            Console.WriteLine(tempResult.Count);//3
            foreach (MagicCard card in tempResult)
            {//for each card with cmc 2, print the name and the cmc
                Console.WriteLine($"{card.Name} has a converted mana cost of {card.ConvertedManaCost}");
            }

            Console.WriteLine(AllCardsOfCMC(cards, -1).Count);//0

            Console.WriteLine("Press ENTER to end program...");
            Console.ReadLine();

        }//End of Main

        //Methods
        public static bool ContainsCardName(string[] cardNameArray, string searchName)
        {
            foreach (string name in cardNameArray)
            {
                if (name == searchName)
                {
                    return true;
                }
            }
            return false;
        }

        public static int FirstIndexOfRarity(string[] cardRarityArray, string searchRarity)
        {
            for (int i = 0; i < cardRarityArray.Length; i++)
            {
                if (cardRarityArray[i] == searchRarity)
                {
                    return i;
                }
            }
            return -1;
        }

        public static List<int> AllIndeciesOfRarity(string[] cardRarityArray, string searchRarity)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < cardRarityArray.Length; i++)
            {
                if (cardRarityArray[i] == searchRarity)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static List<MagicCard> AllCardsOfCMC(MagicCard[] cardArray, int searchCMC)
        {
            List<MagicCard> result = new List<MagicCard>();
            foreach (MagicCard card in cardArray)
            {
                if (card.ConvertedManaCost == searchCMC)
                {
                    result.Add(card);
                }
            }
            return result;
        }

        static void MyPreload()
        {
            cardNames = new string[]
            {
                "Increasing Vengeance",
                "Slagwoods Bridge",
                "Cinder Glade",
                "Sunken Citadel",
                "Omnath, Locus of Rage",
                "Obuun, Mul Daya Ancestor",
                "Loyal Unicorn",
                "Beast Within",
                "Thought Vessel",
                "Fall of the Hammer"
            };

            cardRarities = new string[]
            {
                "Rare",
                "Common",
                "Rare",
                "Rare",
                "Mythic Rare",
                "Mythic Rare",
                "Uncommon",
                "Uncommon",
                "Rare",
                "Common"
            };

            cards = new MagicCard[]
            {
                new MagicCard("Increasing Vengeance", "Rare", 2),
                new MagicCard("Slagwoods Bridge", "Common", 0),
                new MagicCard("Cinder Glade", "Rare", 0),
                new MagicCard("Sunken Citadel", "Rare", 0),
                new MagicCard("Omnath, Locus of Rage", "Mythic Rare", 7),
                new MagicCard("Obuun, Mul Daya Ancestor", "Mythic Rare", 4),
                new MagicCard("Loyal Unicorn", "Uncommon", 4),
                new MagicCard("Beast Within", "Uncommon", 3),
                new MagicCard("Thought Vessel", "Rare", 2),
                new MagicCard("Fall of the Hammer", "Common", 2)
            };
        }

        //End of Methods

    }//End of Program
}//End of Namespace
