namespace FilteringV10
{
    public class Filterless10 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value < 10;
        }
    }
}