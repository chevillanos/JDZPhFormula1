using JDZPhFormula1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDZPhFormula1.Services
{
    public interface IHomeService
    {
        HomeDetails HomeDetails(string classification);
    }
}
