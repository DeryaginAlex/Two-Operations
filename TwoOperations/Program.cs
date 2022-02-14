namespace TwoOperations {
    class Program {
        static void Main(string[] args) {
            OperationsСalculator calculator = new OperationsСalculator();
            List<long> values = new List<long> { 1024, 10 };
            List<int> result = new List<int> { };
            result = calculator.GetMinOperations(values);
            foreach(var item in result) {
                Console.WriteLine(item);
            }
        }
    }
}