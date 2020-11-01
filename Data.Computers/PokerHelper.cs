using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Computers
{
    public static class PokerHelper
    {
        public static int ComputeWinner(List<string> cardsFirstPlayer, List<string> cardsSecondPlayer)
        {
            if (IsRoyalFlush(cardsFirstPlayer) && !IsRoyalFlush(cardsSecondPlayer))
            {
                return 1;
            } 
            if (!IsRoyalFlush(cardsFirstPlayer) && IsRoyalFlush(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsStraightFlush(cardsFirstPlayer) && !IsStraightFlush(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsStraightFlush(cardsFirstPlayer) && IsStraightFlush(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsFourOfAKind(cardsFirstPlayer) && IsFourOfAKind(cardsSecondPlayer))
            {
                var valueFourOfAKindFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 4).Single().Key;
                var valueFourOfAKindSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 4).Single().Key;

                //var valueSingleCardFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 1).Single().Key;
                //var valueSingleCardSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 1).Single().Key;

                //if (valueFourOfAKindFirstPlayer == valueFourOfAKindSecondPlayer)
                //{
                //    return valueSingleCardFirstPlayer > valueSingleCardSecondPlayer ? 1 : 2;
                //}

                if (valueFourOfAKindFirstPlayer != valueFourOfAKindSecondPlayer)
                {
                    return valueFourOfAKindFirstPlayer > valueFourOfAKindSecondPlayer ? 1 : 2;
                }        
            }
            if (IsFourOfAKind(cardsFirstPlayer) && !IsFourOfAKind(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsFourOfAKind(cardsFirstPlayer) && IsFourOfAKind(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsFullHouse(cardsFirstPlayer) && IsFullHouse(cardsSecondPlayer))
            {
                var valueThreeOfAKindFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 3).Single().Key;
                var valueThreeOfAKindSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 3).Single().Key;

                //var valuePairFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Single().Key;
                //var valuePairSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Single().Key;

                //if (valueThreeOfAKindFirstPlayer == valueThreeOfAKindSecondPlayer)
                //{
                //    return valuePairFirstPlayer > valuePairSecondPlayer ? 1 : 2;
                //}

                if (valueThreeOfAKindFirstPlayer != valueThreeOfAKindSecondPlayer)
                {
                    return valueThreeOfAKindFirstPlayer > valueThreeOfAKindSecondPlayer ? 1 : 2;
                }                
            }
            if (IsFullHouse(cardsFirstPlayer) && !IsFullHouse(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsFullHouse(cardsFirstPlayer) && IsFullHouse(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsFlush(cardsFirstPlayer) && !IsFlush(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsFlush(cardsFirstPlayer) && IsFlush(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsStraight(cardsFirstPlayer) && !IsStraight(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsStraight(cardsFirstPlayer) && IsStraight(cardsSecondPlayer))
            {
                return 2;
            }

            if (IsThreeOfAKind(cardsFirstPlayer) && IsThreeOfAKind(cardsSecondPlayer))
            {
                var valueThreeOfAKindFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 3).Single().Key;
                var valueThreeOfAKindSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 3).Single().Key;

                if (valueThreeOfAKindFirstPlayer != valueThreeOfAKindSecondPlayer)
                {
                    return valueThreeOfAKindFirstPlayer > valueThreeOfAKindSecondPlayer ? 1 : 2;
                }
            }
            if (IsThreeOfAKind(cardsFirstPlayer) && !IsThreeOfAKind(cardsSecondPlayer))
            {
                return 1;
            }
            if (!IsThreeOfAKind(cardsFirstPlayer) && IsThreeOfAKind(cardsSecondPlayer))
            {
                return 2;
            }

            if (ContainsTwopairs(cardsFirstPlayer) && ContainsTwopairs(cardsSecondPlayer))
            {
                var valueHighestPairFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Select(group => group.Key).Max();
                var valueHighestPairSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Select(group => group.Key).Max();

                var valueLowestPairFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Select(group => group.Key).Min();
                var valueLowestPairSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Select(group => group.Key).Min();

                if (valueHighestPairFirstPlayer == valueHighestPairSecondPlayer)
                {
                    if (valueLowestPairFirstPlayer != valueLowestPairSecondPlayer)
                    {
                        return valueLowestPairFirstPlayer > valueLowestPairSecondPlayer ? 1 : 2;
                    }
                }

                if (valueHighestPairFirstPlayer != valueHighestPairSecondPlayer)
                {
                    return valueHighestPairFirstPlayer > valueHighestPairSecondPlayer ? 1 : 2;
                }   
            }
            if (ContainsTwopairs(cardsFirstPlayer) && !ContainsTwopairs(cardsSecondPlayer))
            {
                return 1;
            }
            if (!ContainsTwopairs(cardsFirstPlayer) && ContainsTwopairs(cardsSecondPlayer))
            {
                return 2;
            }

            if (ContainsAPair(cardsFirstPlayer) && ContainsAPair(cardsSecondPlayer))
            {
                var valuePairFirstPlayer = cardsFirstPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Single().Key;
                var valuePairSecondPlayer = cardsSecondPlayer.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Single().Key;

                if (valuePairFirstPlayer != valuePairSecondPlayer)
                {
                    return valuePairFirstPlayer > valuePairSecondPlayer ? 1 : 2;
                }
            }
            if (ContainsAPair(cardsFirstPlayer) && !ContainsAPair(cardsSecondPlayer))
            {
                return 1;
            }
            if (!ContainsAPair(cardsFirstPlayer) && ContainsAPair(cardsSecondPlayer))
            {
                return 2;
            }

            while (true)
            {
                var highestValueFirstPlayer = HighestValue(cardsFirstPlayer);
                var highestValueSecondPlayer = HighestValue(cardsSecondPlayer);

                if (highestValueFirstPlayer != highestValueSecondPlayer)
                {
                    return highestValueFirstPlayer > highestValueSecondPlayer ? 1 : 2;
                }

                cardsFirstPlayer.Remove(cardsFirstPlayer.First(card => ValueOfCard(card) == highestValueFirstPlayer));
                cardsSecondPlayer.Remove(cardsSecondPlayer.First(card => ValueOfCard(card) == highestValueSecondPlayer));
            }
        }

        private static int ValueOfCard(string card)
        {
            var cardValue = card[0] switch
            {
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                'T' => 10,
                'J' => 11,
                'Q' => 12,
                'K' => 13,
                'A' => 14,
                _ => throw new NotImplementedException()
            };

            return cardValue;
        }

        private static bool IsFlush(List<string> cards)
        {
            var suitOfFirstCard = cards[0][1];

            foreach (string card in cards)
            {
                if (card[1] != suitOfFirstCard)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsRoyalFlush(List<string> cards)
        {
            var cardValues = cards.Select(card => ValueOfCard(card)).ToList();
            var requiredValuesForRoyalFlush = new List<int> { 10, 11, 12, 13, 14 };

            return cardValues.SequenceEqual(requiredValuesForRoyalFlush) && IsFlush(cards);
        }

        private static bool IsStraightFlush(List<string> cards)
        {
            return IsStraight(cards) && IsFlush(cards);
        }

        private static bool IsStraight(List<string> cards)
        {
            var cardValues = cards.Select(card => ValueOfCard(card)).ToList();
            cardValues.Sort();
            var minimalCardValue = cardValues.Min();
            var requiredValuesForStraight = Enumerable.Range(minimalCardValue, 5);
            var requiredValuesForLowStraight = new List<int>{ 2, 3, 4, 5, 15 };

            return cardValues.SequenceEqual(requiredValuesForStraight) || cardValues.SequenceEqual(requiredValuesForLowStraight);
        }

        private static bool IsFourOfAKind(List<string> cards)
        {
            return IsNOfAKind(cards, 4);
        }

        private static bool IsThreeOfAKind(List<string> cards)
        {
            return IsNOfAKind(cards, 3);
        }

        private static bool ContainsAPair(List<string> cards)
        {
            return IsNOfAKind(cards, 2);
        }

        private static bool IsFullHouse(List<string> cards)
        {
            var cardsGroupedByValue = cards.GroupBy(card => ValueOfCard(card));
            return cardsGroupedByValue.Any(group => group.Count() == 2) && cardsGroupedByValue.Any(Group => Group.Count() == 3);
        }

        private static bool ContainsTwopairs(List<string> cards)
        {
            return cards.GroupBy(card => ValueOfCard(card)).Where(group => group.Count() == 2).Count() == 2;
        }

        private static bool IsNOfAKind(List<string> cards, int n)
        {
            return cards.GroupBy(card => ValueOfCard(card)).Any(group => group.Count() == n);
        }

        private static int HighestValue(List<string> cards)
        {
            return cards.Select(card => ValueOfCard(card)).Max();
        }
    }
}
