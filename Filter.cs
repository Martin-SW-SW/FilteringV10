using System.Collections.Generic;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, List<IFilterCondition> filterCondition)
        {
            List<int> filteredValues = new List<int>();

            foreach (var v in filterCondition)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    int value = values[i];
                    if (v.Condition(value))
                    {
                        if (!filteredValues.Contains(value))
                        {
                            filteredValues.Add(value);
                        }
                    } else values.Remove(value);
                    
                }
            }

            return filteredValues;
        }
    }
}