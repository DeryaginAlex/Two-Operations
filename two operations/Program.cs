using System;
using System.Collections.Generic;

namespace two_operations {
    class Program {
        static void Main(string[] args) {
            Operations operations = new Operations();
            List<long> kValues = new List<long> { 1024,10};
            List<int> result = new List<int> { };
            result = operations.getMinOperations(kValues);

            for(int i = 0 ; i < result.Count ; i++) {
                Console.WriteLine(result[i]);
            }

        }
    }
}
