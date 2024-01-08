namespace GA_LinearSearch
{
    internal class MagicCard
    {
        //Attributes
        public string Name { get; set; }
        public string Rarity { get; set; }
        public int ConvertedManaCost { get; set;}
        //Constructor
        public MagicCard(string name, string rarity, int cmc)
        {
            Name = name;
            Rarity = rarity;
            ConvertedManaCost = cmc;
        }
    }
}