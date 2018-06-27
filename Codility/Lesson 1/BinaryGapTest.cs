using Xunit;

namespace Lesson1
{
    public class BinaryGapTest {

        private BinaryGap _binaryGap {get; set;}

        public BinaryGapTest() 
        {
            _binaryGap = new BinaryGap();
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(32, 0)]
        [InlineData(2147483647, 0)]
        [InlineData(1073741825, 29)]
        public void TestSolution(int input, int longestGap)
        {
            int result = _binaryGap.solution(input);

            Assert.Equal(longestGap, result);
        }
    }
}