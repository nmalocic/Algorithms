namespace Codility.Lesson_2.CyclicRotation.Implementations
{
    public class CalculatingNextIndex : ICyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int[] retVal = new int[A.Length];

            for(int i=0; i<A.Length;i++)
            {
                int newIndex = (i + K) % A.Length;
                retVal[newIndex] = A[i];
            }

            return retVal;
        }
    }
}
