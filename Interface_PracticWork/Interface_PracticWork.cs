namespace Interface_PracticWork
{
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    interface IOutput
    {
        void Show();
        void Show(string info);

    }
    interface IMath
    {
        int Max();
        int Min();
        int Avg();
        bool Search(int value);
    }
    class MyArray : IOutput, IMath, ISort
    {
        int[] arr;
        public MyArray(int size)
        {
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }
            Console.WriteLine();
        }

        public int Avg()
        {
            return (int)arr.Average();
        }
        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }

        public bool Search(int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true) {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
    }
    internal class Task1
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(20);
            array.Show();
            array.Show("I my array: ");
            Console.WriteLine($"My max: {array.Max()}\nMy min: {array.Min()}");
            Console.WriteLine(array.Search(90));
            Console.WriteLine($"My avg : {array.Avg()}");
            Console.WriteLine($"SortMax : ");
            array.SortAsc();
            array.Show();
            Console.WriteLine($"SortByParam : ");
            array.SortByParam(false);
            array.Show();

        }
    }
}