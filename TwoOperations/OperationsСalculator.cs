using System;
using System.Collections.Generic;

namespace TwoOperations {
    public class OperationsСalculator {
        public List<int> GetMinOperations(List<long> kValues) {
            List<int> result = new List<int> { };
            if(kValues.Count==0) {
                throw new ArgumentNullException("Не задан список значений");
            }
            foreach(int item in kValues) {
                long value = item;
                int count = 0;
                while(value != 1) {
                    if(value % 2 == 0) {
                        value = value / 2;
                    } else {
                        value--;
                    }
                    count++;
                }
                result.Add(count);
            }
            return result;
        }
    }
}
