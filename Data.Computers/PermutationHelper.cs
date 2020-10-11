using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class PermutationHelper
    {
        public static List<string> GetListOfAllPossiblePermutations(List<char> characters)
        {
            var numberOfCharacters = characters.Count;

            switch (numberOfCharacters)
            {
                case 1:
                    return new List<string> { characters[0].ToString() };
                case 2:
                    return new List<string> { characters[0].ToString() + characters[1].ToString(), characters[1].ToString() + characters[0].ToString() };
                default:
                    // a + permututations(bc),
                    // b + permutatations(ac),
                    // c + permutations(ab)
                    var permutationsOfCharacters = new List<string>();

                    characters.ForEach(character =>
                    {
                        var otherCharacters = characters.Where(othercharacter => othercharacter != character).ToList();
                        var permutationsOtherCharacters = GetListOfAllPossiblePermutations(otherCharacters);

                        permutationsOfCharacters.AddRange(permutationsOtherCharacters.Select(permutation => character.ToString() + permutation));
                    });

                    return permutationsOfCharacters;
            }
        }
    }
}
