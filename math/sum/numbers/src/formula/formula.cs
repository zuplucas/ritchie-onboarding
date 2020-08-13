using System;
using main;

namespace formula
{
    public class Hello
    {
        public string N1;
        public string N2;
        public string Operation;
        public Hello(string sptx, string sptl, string sptb)
        {
            this.N1 = sptx;
            this.N2 = sptl;
            this.Operation = sptb;
            Console.WriteLine("Computing the " + Operation + " with " + N1 + " AND " + N2);
        }

        public void Run() {
            double n1 = 0;
            
            if (!Double.TryParse(N1, out n1)) {
                Console.WriteLine("First argument must be a number: " + N1);
                return;
            }
            double n2 = 0;

            if (!Double.TryParse(N2, out n2)) {
                Console.WriteLine("Second argument must be a number: " + N2);
                return;
            }

            try
            {
                double value = 0;
                switch(Operation.ToUpper()) {
                    case "SUM": 
                        value = sum(n1, n2);
                        break;
                    case "SUBTRACT": 
                        value = subtract(n1, n2);
                        break;
                    case "MULTIPLY": 
                        value = multiply(n1, n2);
                        break;            
                    case "DIVIDE": 
                        value = divide(n1, n2);
                        break;
                }
                Console.WriteLine("Result: " + value);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: " + ex.Message);
            }
        
    
        }

        private double sum(double n1, double n2) {
            return n1 + n2;
        }

        private double subtract(double n1, double n2) {
            return n1 - n2;
        }

        private double multiply(double n1, double n2) {
            return n1 * n2;
        }

        private double divide(double n1, double n2) {
            if (n2 == 0) {
                throw new Exception("Second argument cannot be ZERO");                
            }
            return n1/n2;
        }
    }
}
