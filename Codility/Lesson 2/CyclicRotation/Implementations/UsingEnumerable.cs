using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Lesson_2.CyclicRotation.Implementations
{
    public class UsingEnumerable : ICyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            var iterators = GetNewPositions(K, A.Length);

            return Enumerable.Range(0, A.Length).Select(e =>
            {
                return A[iterators.ElementAt(e)];
            }).ToArray();
        }

        /// <summary>
        /// Returns positions of new array in offset.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private IEnumerable<int> GetNewPositions(int offset, int length)
        {
            var currentElement = length - offset;

            while (true)
            {
                yield return currentElement;

                currentElement++;
                if (currentElement >= length)
                {
                    currentElement = 0;
                }
            }
        }
    }
}
