namespace ex10_delegators
{
    delegate int MyDelegate(int a, int b);
    delegate int Compare(int a, int b); // 두 값을 비교하는 대리자

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Sorting
    {
        // 오름차순 비교
        public int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 1;
            else
                return -1;
        }

        // 내림차순 비교
        public int AscendingCompare(int a, int b)
        {
            if (a < b)
                return -1;
            else if (a == b)
                return -1;
            else
                return 1;
        }

        public void BubbleSort(int[] DataSet, Compare comparer)
        {
            int i = 0, j = 0, temp = 0;
            for (i = 0; i < DataSet.Length; i++) 
            {
                for(j = 0; j < DataSet.Length - 1; j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 10, 5, 4, 1, 9 };
            Sorting sorting = new Sorting();

            Console.WriteLine("오름차순 정렬");
            sorting.BubbleSort(array, new Compare(sorting.AscendingCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine();

            Console.WriteLine("내림차순 정렬");
            sorting.BubbleSort(array, new Compare(sorting.DescendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine();







            Calculator calc = new Calculator(); // 객체 생성
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus); // int a, int b가 아닌 Calculator 객체의 Plus() 메서드를 전달
            var result = Callback(10, 4);
            Console.WriteLine(result); // 14

            Callback = new MyDelegate(calc.Minus); // int a, int b가 아닌 Calculator 객체의 Plus() 메서드를 전달
            result = Callback(10, 4);
            Console.WriteLine(result); // 6
        }
    }
}
