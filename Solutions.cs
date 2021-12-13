namespace OjProblems;

public static class Solutions
{
    public static void Problem50()
    {
        int n = int.Parse(Console.ReadLine()), count = 0;

        for (int i = 1; i <= n; i++)
        {
            int temp = i;
            while (temp != 0)
            {
                if (temp % 10 == 3)
                {
                    count++;
                }
                temp /= 10;
            }
        }
        System.Console.WriteLine(count);
    }
    public static void Problem49()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int space = n - i;
            while (space-- > 0)
            {
                System.Console.Write(" ");
            }
            int stars = i * 2 - 1;
            while (stars-- > 0)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        for (int i = n - 1; i >= 1; i--)
        {
            int space = n - i;
            while (space-- > 0)
            {
                System.Console.Write(" ");
            }
            int stars = i * 2 - 1;
            while (stars-- > 0)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
    public static void Problem48()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int n = numbers[0], m = numbers[1];

        while (n != m)
        {
            if (n > m)
            {
                n %= m;
            }
            else
            {
                m %= n;
            }
            if (n == 0)
            {
                n = m;
            }
            if (m == 0)
            {
                m = n;
            }
        }
        System.Console.WriteLine(n);
    }
    public static void Problem47()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sum = 0;

        foreach (var num in numbers)
        {
            if (num == 0)
            {
                break;
            }
            sum += num;
        }
        System.Console.WriteLine($"{sum}");
    }
    public static void Problem46()
    {
        long n = long.Parse(Console.ReadLine());
        for (long i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                System.Console.Write($"{i} ");
            }
        }
        System.Console.WriteLine();
    }
    public static void Problem45()
    {
        string str = Console.ReadLine();

        foreach (var element in str)
        {
            System.Console.Write($"{Convert.ToInt64(element):X} "); ;
        }
        System.Console.WriteLine();
    }
    public static void Problem44()
    {
        long n = long.Parse(Console.ReadLine());

        long f1 = 0, f2 = 1, f3 = f1 + f2;

        for (int i = 2; i < n; i++)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
        }
        System.Console.WriteLine(f3);
    }
    public static int Collatz(long n)
    {
        int count = 0;
        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = n * 3 + 1;
            }
            count++;
        }
        return count;
    }
    public static void Problem43()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

        if (Collatz(numbers[0]) < Collatz(numbers[1]))
        {
            System.Console.WriteLine($"{numbers[0]} {Collatz(numbers[0])}");
        }
        else
        {
            System.Console.WriteLine($"{numbers[1]} {Collatz(numbers[1])}");
        }
    }
    public static void Problem42()
    {
        long n = long.Parse(Console.ReadLine()), x = 0, y = 0;

        var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (var i = 0; i < nums.Length; i++)
        {
            switch (i % 4)
            {
                case 0: y += nums[i]; break;
                case 1: x += nums[i]; break;
                case 2: y -= nums[i]; break;
                case 3: x -= nums[i]; break;
                default: break;
            }
        }
        System.Console.WriteLine($"{x} {y}");
    }
    public static void Problem41()
    {
        long n = long.Parse(Console.ReadLine());
        for (long i = n; ; i++)
        {
            bool tubmi = true;
            for (long j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    tubmi = false;
                    break;
                }
            }
            if (tubmi == true)
            {
                System.Console.WriteLine(i);
                break;
            }
        }
    }
    public static void Problem40()
    {
        long n = long.Parse(Console.ReadLine());

        for (int i = 1; ; i++)
        {
            if (n % i == 0)
            {
                n /= i;
            }
            else
            {
                break;
            }
        }
        if (n == 1)
        {
            System.Console.WriteLine("true");
        }
        else
        {
            System.Console.WriteLine("false");
        }
    }

    public static void Problem39()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        foreach (var num in nums)
        {
            sum += (int)Math.Pow(num, 3);
        }
        System.Console.WriteLine(sum);
    }

    public static void Problem38()
    {
        var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        string res = new string("false");
        for (int i = 0; i < 1; i++)
        {
            if (Math.Pow(nums[i], 2) + Math.Pow(nums[i + 1], 2) == Math.Pow(nums[i + 2], 2))
            {
                res = "true";
            }
            else if (Math.Pow(nums[i], 2) + Math.Pow(nums[i + 2], 2) == Math.Pow(nums[i + 1], 2))
            {
                res = "true";
            }
            else if (Math.Pow(nums[i + 1], 2) + Math.Pow(nums[i + 2], 2) == Math.Pow(nums[i], 2))
            {
                res = "true";
            }
        }
        System.Console.WriteLine(res);
    }
    public static void Problem37()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1: System.Console.WriteLine($"Americano\n{(m - 500) / 500} {(m - 500) % 500 / 100}"); break;
            case 2: System.Console.WriteLine($"Caffe Latte\n{(m - 400) / 500} {(m - 400) % 500 / 100}"); break;
            case 3: System.Console.WriteLine($"Lemon Tea\n{(m - 300) / 500} {(m - 300) % 500 / 100}"); break;
            default: break;
        }

    }
    public static void Problem36()
    {
        var characters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        if (characters[1] == "+")
        {
            System.Console.WriteLine($"{int.Parse(characters[0]) + int.Parse(characters[2])}");
        }
        else
        {
            System.Console.WriteLine($"{int.Parse(characters[0]) - int.Parse(characters[2])}");
        }
    }
    public static void Problem35()
    {
        int strike = 0, ball = 0;
        var a = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var b = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        if (b[0] == a[0])
        {
            strike++;
        }
        else if (b[0] == a[1] || b[0] == a[2])
        {
            ball++;
        }
        if (b[1] == a[1])
        {
            strike++;
        }
        else if (b[1] == a[0] || b[1] == a[2])
        {
            ball++;
        }
        if (b[2] == a[2])
        {
            strike++;
        }
        else if (b[2] == a[0] || b[2] == a[1])
        {
            ball++;
        }
        System.Console.WriteLine($"{strike}S{ball}B");
    }
    public static void Problem34()
    {
        char ch = char.Parse(Console.ReadLine());

        if (ch >= 'A' && ch <= 'Z')
        {
            System.Console.WriteLine((char)(ch + 32));
        }
        else if (ch >= 'a' && ch <= 'z')
        {
            System.Console.WriteLine((char)(ch - 32));
        }
        else
        {
            System.Console.WriteLine("none");
        }
    }
    public static void Problem33()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        while (count <= 2)
        {
            if (count == 2)
            {
                break;
            }
            int m = int.Parse(Console.ReadLine());
            if (m > n)
            {
                System.Console.WriteLine("PASTGA");
            }
            else if (m < n)
            {
                System.Console.WriteLine("TEPAGA");
            }
            else
            {
                System.Console.WriteLine("YORVORDIZ");
                break;
            }
            count++;
        }
    }
    public static void Problem32()
    {
        int year = int.Parse(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            System.Console.WriteLine(1);
        }
        else
        {
            System.Console.WriteLine(0);
        }
    }
    public static void Problem31()
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0 && n % 3 == 0 && n % 5 == 0)
        {
            System.Console.WriteLine("A");
        }
        else if (n % 2 == 0 && n % 3 == 0)
        {
            System.Console.WriteLine("B");
        }
        else if (n % 2 == 0 && n % 5 == 0)
        {
            System.Console.WriteLine("C");
        }
        else if (n % 3 == 0 && n % 5 == 0)
        {
            System.Console.WriteLine("D");
        }
        else if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
        {
            System.Console.WriteLine("E");
        }
        else
        {
            System.Console.WriteLine("N");
        }
    }
    public static void Problem30()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        int max = new int();
        foreach (var item in numbers)
        {
            if (max < item)
            {
                max = item;
            }
        }

        System.Console.WriteLine(max);
    }
    public static void Problem29()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        if (Math.Pow(numbers[0], 2) == numbers[1])
        {
            System.Console.WriteLine($"{numbers[0]}*{numbers[0]}={numbers[1]}");
        }
        else if (Math.Pow(numbers[1], 2) == numbers[0])
        {
            System.Console.WriteLine($"{numbers[1]}*{numbers[1]}={numbers[0]}");
        }
        else
        {
            System.Console.WriteLine("none");
        }
    }
    public static void Problem28()
    {
        int n = int.Parse(Console.ReadLine());

        System.Console.WriteLine((n >= 0 && n < 40 ? "tashqarida o'yna" : "ichkarida o'yna"));
    }
    public static void Problem27()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        if (numbers[0] == 0)
        {
            numbers[0] = 24;
        }
        int res = numbers[0] * 60 + numbers[1] - 45;

        System.Console.WriteLine($"{res / 60} {res % 60}");
    }
    public static void Problem26()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        System.Console.WriteLine((numbers[0] > numbers[1] ? $"{numbers[0] / numbers[1]}\n{numbers[0] % numbers[1]}" : $"{numbers[1] / numbers[0]}\n{ numbers[1] % numbers[0] }"));
    }
    public static void Problem25()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        if (numbers[0] > numbers[1])
        {
            System.Console.WriteLine(numbers[0]);
        }
        else
        {
            System.Console.WriteLine(numbers[1]);
        }
    }
    public static void Problem24()
    {
        int n = int.Parse(Console.ReadLine());

        System.Console.WriteLine((n % 2 == 0 ? "even" : "odd"));
    }
    public static void Problem23()
    {
        char ch = char.Parse(Console.ReadLine());

        System.Console.WriteLine(((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') ? 1 : 0));
    }
    public static void Problem22()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine((n >= 20 && n <= 30 ? 1 : 0));
    }
    public static void Problem21()
    {
        double N = double.Parse(Console.ReadLine());

        double PI = 3.14;
        double R = N / (2 * PI);
        double area = PI * Math.Pow(R, 2);

        Console.WriteLine(Math.Round(area));
    }
}