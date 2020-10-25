using System.Collections.Generic;

namespace Data.Computers
{
    public static class SubsetHelper
    {
        public static List<List<T>> AllSubsets<T>(List<T> currentList)
        {
            var subsets = new List<List<T>>();

            if (currentList.Count == 0)
            {
                subsets.Add(new List<T>());
                return subsets;
            }

            else
            {
                var firstItemOfList = currentList[0];
                var tempList = currentList;
                tempList.Remove(firstItemOfList);

                foreach (List<T> list in AllSubsets(tempList))
                {
                    var listWithoutFirstItem = new List<T>(list);
                    var listWithFirstItem = new List<T>(list)
                    {
                        firstItemOfList
                    };

                    subsets.Add(listWithoutFirstItem);
                    subsets.Add(listWithFirstItem);
                }

                return subsets;
            }
        }

        public static List<List<T>> AllStrictSubsets<T>(List<T> currentList)
        {
            var strictSubsets = AllSubsets(currentList);
            strictSubsets.RemoveAt(strictSubsets.Count - 1);
            strictSubsets.RemoveAt(0);
            return strictSubsets;
        }

        public static List<List<T>> AllNonEmptySubsets<T>(List<T> currentList)
        {
            var strictSubsets = AllSubsets(currentList);
            strictSubsets.RemoveAt(0);
            return strictSubsets;
        }
    }
}
