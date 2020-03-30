namespace FilteringV10
{
    public class FilterGreater10 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value > 10;
        }
    }
}