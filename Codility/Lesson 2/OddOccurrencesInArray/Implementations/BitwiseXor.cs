using System.Linq;

namespace Codility.Lesson_2.OddOccurrencesInArray.Implementations
{
    public class BitwiseXor : IOddOccurences
    {
        public int solution(int[] A)
        {
            return A.Aggregate(0, (current, next) => current ^ next);
        }
    }
}
