using System.Collections.Generic;

namespace no_1
{
    public class IHomework : IHomework13
    {
        public IEnumerable<int> Homework13(IEnumerable<int> numbers)
        {
            var result = new List<int>();
            foreach (var item in numbers)
            {
                var ss = item.ToString();
                if (ss.Length == 5)
                {
                    ss = "0" + ss;
                }
                else if (ss.Length == 4)
                {
                    ss = "00" + ss;
                }
                else if (ss.Length == 3)
                {
                    ss = "000" + ss;
                }
                else if (ss.Length == 2)
                {
                    ss = "0000" + ss;
                }
                else if (ss.Length == 1)
                {
                    ss = "00000" + ss;
                }
                var no0_1 = (ss[0] == '9');
                var no0_2 = (ss[0] != '9');
                var no1_1 = (ss[1] == '9');
                var no1_2 = (ss[1] != '9');
                var no2_1 = (ss[2] == '9');
                var no2_2 = (ss[2] != '9');
                var no3_1 = (ss[3] == '9');
                var no3_2 = (ss[3] != '9');
                var no4_1 = (ss[4] == '9');
                var no4_2 = (ss[4] != '9');
                var no5_1 = (ss[5] == '9');
                var no5_2 = (ss[5] != '9');
                /* */
                if (no0_1 && no1_1 && no2_2)
                {
                    result.Add(item);
                }
                else if (no0_2 && no1_1 && no2_1 && no3_2)
                {
                    result.Add(item);
                }
                else if (no1_2 && no2_1 && no3_1 && no4_2)
                {
                    result.Add(item);
                }
                else if (no2_2 && no3_1 && no4_1 && no5_2)
                {
                    result.Add(item);
                }
                else if (no3_2 && no4_1 && no5_1)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
