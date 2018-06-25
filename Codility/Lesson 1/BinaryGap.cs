using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson1 {

    public class BinaryGap {

        /// <summary>
        /// functional solution, easy to read and understand.
        /// it may not fit into required speed or memory constraints.
        /// Works even with negative int input.
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public int solution2(int N) {
             return Convert.ToString(N, 2) // Get binary representation
                     .TrimEnd('0') // discard end zeroes as they don't have relevance
                     .Split('1', StringSplitOptions.RemoveEmptyEntries) // split remaining string into substrings and discard empty substrings
                     .Aggregate(0, (maximum, next) => { return next.Length > maximum ? next.Length : maximum; }); //return longest substring or 0 if no substrings
        }


        /// <summary>
        /// "ifs and whiles" solution.
        /// Uses total of 4 integers and up to 31 loops. 
        /// Fits into speed and memory constraints.
        /// WOULD NOT WORK FOR NEGATIVE NUMBERS (but text states that we don't need to worry about those).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int solution(int n)
        {
            int powerOf2 = 1073741824; // 2^30
            short max = 0; // current Maximum
            short current = 0; // auxiliarry for tracking current zero streak.
            int remaining = n; // used to not edit input parameter. Not really neccecary.

            // find first number 1 in binary representation.
            while (powerOf2 > remaining)
            {
                powerOf2 /= 2;
            }

            do
            {
                if (remaining >= powerOf2) // found new 1 in the binary representation.
                {
                    remaining -= powerOf2; 
                    max = max > current ? max : current;  // check if latest streak was maximal.
                    current = 0; //reset streak.
                }
                else // found zero
                {
                    current++; // increase streak
                }

                powerOf2 /= 2; //check next decimal place
            } while ((powerOf2 > 0) && (remaining > 0)); // while we have decimals OR number is out.

            return max;
        }
    }
}