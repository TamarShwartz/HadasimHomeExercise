using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ICoronaTestBL
    {
        Task<string> GetTtueAnswer(int id);
        Task<string> GetRecoveryDate(int id);
        Task Post(CoronaTest value);
    }
}
