using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface ICoronaTestDL
    {
        Task<List<CoronaTest>> Get(int id);
        Task Post(CoronaTest coronaTest);
    }
}
