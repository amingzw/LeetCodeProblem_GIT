/**
* 类 名 称  :_999_Available_Captures_for_Rook
* 作    者  :zw-pc
* 命名空间  :LeetCodeProblem.Array
* CLR 版本  :4.0.30319.42000
* 创建时间  :2019/5/6 10:19:58
* 修改时间  :2019/5/6 10:19:58
*
* Copyright  @ 2018. All Rights reserved
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem.Array
{
    public class _999_Available_Captures_for_Rook
    {
        public static int NumRookCaptures(char[][] board)
        {
            int rowIndex = 0;
            int colIndex = 0;
            int rookCount = 0;
            char[] col = new char[board.Length];
            for (int i = 0; i < board.Length; ++i)
            {
                if (board[i].Contains('R'))
                {
                    rowIndex = i;
                    colIndex = board[i].ToList().IndexOf('R');
                }
            }
            for (int i = 0; i < board.Length; ++i)
            {
                col[i] = board[i][colIndex];
            }
            int k = colIndex;
            while (k < 8)
            {
                if (board[rowIndex][k] == 'B')
                {
                    break;
                }
                else if (board[rowIndex][k] == 'p')
                {
                    rookCount++;
                    break;
                }
                k++;
            }
            k = colIndex;
            while (k>=0)
            {
                if (board[rowIndex][k] == 'B')
                {
                    break;
                }
                else if (board[rowIndex][k] == 'p')
                {
                    rookCount++;
                    break;
                }
                k--;
            }

            k = rowIndex;
            while (k >= 0)
            {
                if (board[k][colIndex] == 'B')
                {
                    break;
                }
                else if (board[k][colIndex] == 'p')
                {
                    rookCount++;
                    break;
                }
                k--;
            }
            k = rowIndex;
            while (k < 8)
            {
                if (board[k][colIndex] == 'B')
                {
                    break;
                }
                else if (board[k][colIndex] == 'p')
                {
                    rookCount++;
                    break;
                }
                k++;
            }

            return rookCount;

        }

    }
}
