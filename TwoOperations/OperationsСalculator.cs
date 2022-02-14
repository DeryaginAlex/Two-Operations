using System;
using System.Collections.Generic;

namespace TwoOperations {
    public class OperationsСalculator {
        public List<int> GetMinOperations(List<long> values) {
            List<int> result = new List<int> { };
            if(values.Count == 0) {
                throw new ArgumentNullException("Не задан список значений");
            }
            foreach(int item in values) {
                long tempValue = item;
                int count = 0;
                while(tempValue != 1) {
                    if(tempValue % 2 == 0) {
                        tempValue = tempValue / 2;
                    } else {
                        tempValue--;
                    }
                    count++;
                }
                result.Add(count);
            }
            return result;
        }
    }
}
