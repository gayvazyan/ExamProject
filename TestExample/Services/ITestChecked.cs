using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.MyModels;
using TestExample.ViewModels;

namespace TestExample.Services
{
    public interface ITestChecked
    {
        CitizenTestViewModel TestResult(CitizenTestResults citizenTestResults, EmptyTextViewModel emptyTextViewModel );
    }
}
