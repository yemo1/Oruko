using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrukoData;
using OrukoNG.Models;

namespace OrukoNG.Repositories
{
    public interface IName
    {
        IEnumerable<Tune> GetTunes();

        IEnumerable<ETune> GetETunes();
        string GetByXter(string xter);
        string GetByEXter(string xter);
        string GetByName(string name);
        string GetByEName(string name);

    }
    
}
