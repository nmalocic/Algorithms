using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Lesson_2.CyclicRotation.Implementations
{
    public class UsingLinq : ICyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            List<int> numbersList = new List<int>();
            
            //Double the list
            numbersList.AddRange(A);
            numbersList.AddRange(A);

            var arrLength = A.Length;

            var realShift = arrLength - (K % arrLength);

            var result = numbersList.Skip(realShift).Take(arrLength);

            return result.ToArray();
        }
    }
}
