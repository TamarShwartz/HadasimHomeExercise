using DL;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CoronaTestBL : ICoronaTestBL
    {
        ICoronaTestDL coronaTestDL;
        public CoronaTestBL(ICoronaTestDL coronaTestDL)
        {
            this.coronaTestDL = coronaTestDL;
        }
        public async Task<string> GetTtueAnswer(int id)
        {
            var list = await coronaTestDL.Get(id);
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].TestAnswer == true)
                {

                    return list[i].TestDate.ToString();
                }
            }
            return null;
        }

        public async Task<string> GetRecoveryDate(int id)
        {
            var list = await coronaTestDL.Get(id);
            list.Sort((x, y) => DateTime.Compare((DateTime)x.TestDate, (DateTime)y.TestDate));
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].TestAnswer == true && i + 1 < list.Count)
                    if (list[i + 1].TestAnswer == false)
                    {

                        return list[i + 1].TestDate.ToString();
                    }
            }
            return null;
        }

        public async Task Post(CoronaTest coronaTest)
        {
            await coronaTestDL.Post(coronaTest);
        }
    }
}
