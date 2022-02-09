using System;
using System.Collections.Generic;

namespace TwoOperations {
    class Program {
        static void Main(string[] args) {
            OperationsСalculator calculator = new OperationsСalculator();
            List<long> kValues = new List<long> { 1024,10};
            List<int> result = new List<int> { };
            result = calculator.GetMinOperations(kValues);
            foreach(var item in result) {
                Console.WriteLine(item);
            }
        }
    }
}
