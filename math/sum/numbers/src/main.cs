using System;
using formula;

namespace main
{
    static class main
    {
        static void Main(string[] args)
        {
            string N1       = Environment.GetEnvironmentVariable("NUMBER_ONE");
            string N2       = Environment.GetEnvironmentVariable("NUMBER_TWO");
            string OPERATION    = Environment.GetEnvironmentVariable("OPERATION");
            new formula.Hello(N1, N2, OPERATION).Run();
        }
}
}
