using System;
using System.Collections.Generic;

namespace two_operations {
    public class Operations {
  
        public List<int> getMinOperations(List<long> kValues) {
            List<int> result = new List<int> { };

            if(kValues.Count==0) {
                throw new ArgumentNullException("Не задан список значений");
            }

            for(int i = 0 ; i < kValues.Count ; i++) {
                long value = kValues[i];
                int count = 0;
                while(value!=1) {
                    if(value % 2 == 0) {
                        value = value/2;
                        count++;
                    } else {
                        value--;
                        count++;
                    }
                }
                result.Add(count); 
            }
            return result;
        }


    }
}
