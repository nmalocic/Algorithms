using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility.Lesson_3.TapeEquilibrium
{
    class TapeEquilibriumVersionOne : ITapeEquilibrium
    {
        public int solution(int[] A)
        {
            //TODO: Check for further optimizations, example: sum == Last element of new list.
            var sum = 0;
            return Enumerable.Range(0, A.Length).Select(i =>
            {
                sum += A[i];
                return sum;
            }).ToList() // creates a list of Sums up to now.
            .Aggregate(int.MaxValue, (best, next) => 
            {
                // Balance is calculated as |leftSum - rightSum|. We know that this is equal to |rightSum - leftSum|
                // rightSum = totalSum - leftSum. So, |(TotalSum - leftSum) - leftSum| == |TotalSum - 2 leftSum|
                var abs = Math.Abs(sum - (2 * next));
                
                return abs < best ? abs : best;
            });

        }
    }
}
