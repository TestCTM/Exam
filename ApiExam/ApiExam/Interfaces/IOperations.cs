using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExam.Interfaces
{
    public interface IOperations
    {
        Task<List<string>> FizzBuzz(int n);
    }
}
