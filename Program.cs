namespace CSharp_Origin
{
    class Program
    {
        void base_operation()
        {
            //Use datatype
            int num = 10;

            //use Tuple 
            Tuple<int, float, bool> tuple1 = new Tuple<int, float, bool>(1, 3.2f, false);
            var tuple2 = Tuple.Create(1, 3.2f, false);
            (int, float, bool) tuple3 = (1, 3.2f, false);
            (int Num, float Score, bool IsValid) tuple4 = (1, 3.2f, false);

            //use Array
            int[] array1 = new int[5];
            int[] array2 = { 1, 2, 3, 4, 5 };
        }

        int my_function(int values)
        {
            return values;
        }

        void control_function(string password)
        {
            int length = password.Length;

            if (length >= 10)
            {
                Console.WriteLine($"{password} is long enough!");
            }
            else if (length == 0)
            {
                Console.WriteLine($"{password} is shorter enough!");
            }
            else
            {
                Console.WriteLine($"{password} is Not long enough!");
            }
        }

        void while_function()
        {
            int count = 0;
            while (count <= 10)
            {
                count++;
                Console.WriteLine("Count:{0}", count);
            }

            Console.WriteLine("While End!");
        }

        void for_function()
        {
            for (int i = 0; i < 10; i++) Console.WriteLine("For:{i}");
        }

        void refer_function(in string origin, ref string text, out string part1, out string part2)
        {
            text = origin;
            int mid = origin.Length / 2;
            part1 = text.Substring(0, mid);
            part2 = text.Substring(mid);
        }

        struct Fruit
        {
            String name;
            int grams;
            int price;
        };

        class Rectangle
        {
            private float _width;

            public float Width
            {
                get => _width;
                set
                {
                    if (value <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), "宽度必须大于 0");
                    }

                    _width = value;
                }
            }

            public float Height { get; set; }

            public float get_area()
            {
                return this.Width * this.Height;
            }
        };


        enum State
        {
            On,
            Off,
        }
        
        static void Main(string[] args)
        {
        }
    }
}