using System;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMaxArea()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Assert.AreEqual(49, LeetCodeProblem.Array._11_Container_With_Most_Water.MaxArea(height));
        }


        [Test]
        public void Test977()
        {
            int[] A = new int[]{-7, -3, 2, 3, 11 };
            int[] res = { 4,9,9,49,121};
            Assert.AreEqual(res, LeetCodeProblem.Array._977_Squares_of_a_Sorted_Array.SortedSquares(A));
        }

        [Test]
        public void Test922()
        {
            int[] A = new int[] { 4, 2, 5, 7 };
            int[] res = { 4, 5, 2, 7 };
            Assert.AreEqual(res, LeetCodeProblem.Array._922_Sort_Array_By_Parity_II.SortArrayByParityII(A));
        }

        [TestCase(12, 144)]
        public void Test509(int i,int res)
        {
            Assert.AreEqual(res, LeetCodeProblem.Array._509_Fibonacci_Number
                .Fib(i));
        }

        [Test]
        public void Test999()
        {
            char[][] A =new char[8][];
            A[0] = new char[8] {'.', '.', '.', '.', '.', '.', '.', '.'};
            A[1] = new char[8] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' };
            A[2] = new char[8] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' };
            A[3] = new char[8] { '.', 'p', 'B', 'R', 'B', 'p', '.', '.' };
            A[4] = new char[8] { '.', 'p', 'p', 'B', 'p', 'p', '.', '.' };
            A[5] = new char[8] { '.', 'p', 'p', 'p', 'p', 'p', '.', '.' };
            A[6] = new char[8] { '.', '.', '.', '.', '.', '.', '.', '.' };
            A[7] = new char[8] { '.', '.', '.', '.', '.', '.', '.', '.' };

            Assert.AreEqual(0, LeetCodeProblem.Array._999_Available_Captures_for_Rook
                .NumRookCaptures(A));
        }


    }
}
