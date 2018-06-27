using System;
using System.Linq;

namespace Codility.Lesson_3.PermMissingElem
{
    class CaculateMissing : IPermMissingElem
    {
        public int solution(int[] A)
        {
            var n = A.Length + 1;

            return CalculateSumUpToNumber(n) - A.Sum();
        }

        private int CalculateSumUpToNumber(int n)
        {
            return (n * (n + 1)) / 2;
        }
    }
}
