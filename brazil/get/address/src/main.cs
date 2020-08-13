using System;
using formula;

namespace main
{
    static class main
    {
        static void Main(string[] args)
        {
            string CEP     = Environment.GetEnvironmentVariable("CEP");
            new formula.Hello().Run(CEP);
        }
}
}
