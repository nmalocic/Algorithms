using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Lesson_3.FrogJmp
{
    public class SimpleFrogJmp : IFrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}
