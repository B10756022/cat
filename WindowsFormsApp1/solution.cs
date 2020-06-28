using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class solution
    {
        String[,] tarotSolution = new string[78,2];

        public void sort()
        {

        }
        public string[] tss(int num)
        {
            string[] stmp = new string[2];
            //查詢
            for (int i = 0; i < 78; i++)
                if (i == num)
                {
                    stmp[0] = tarotSolution[i, 0];//牌名放Messenger標題
                    stmp[1] = tarotSolution[i, 1];//解牌放Messenger文字
                }
            return stmp;
        }
            
    }
}
