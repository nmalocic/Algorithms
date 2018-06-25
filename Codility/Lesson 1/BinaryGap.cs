using System;

namespace Lesson1 {
    public class BinaryGap {
        public int solution(int N) {
            string binaryRepresentation = Convert.ToString(N, 2);
            int longestGap = 0;
            bool shouldCountAsGap = false;
            int currentGap = 0;

            for(int i=0; i < binaryRepresentation.Length; i++) {
                if (binaryRepresentation[i].Equals('1')) 
                {
                    if(shouldCountAsGap && longestGap < currentGap) 
                    {
                        longestGap = currentGap;    
                    }
                    shouldCountAsGap = true;
                    currentGap = 0;
                }
                else if(shouldCountAsGap && binaryRepresentation[i].Equals('0')) 
                { 
                    currentGap++;
                }
            }

            return longestGap;
        }
    }
}