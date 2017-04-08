namespace MaximumSumDescent
{
    internal class NakedNode
    {
        public NakedNode(int value, string name = null)
        {
            Name = name;
            Value = value;
            CumulativeValue = value;
        }
        public string Name { get; set; }
        public int Value { get; set; }
        public int CumulativeValue { get; set; }
    }
}
