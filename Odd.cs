using System;
namespace FilteringV10
{
    public class Odd : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value%2 == 0;
        }
    }
}