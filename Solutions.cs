using System.Diagnostics;
namespace OjProblems;

public class Solutions
{
    public int add(int x, int y)
    {
        return x + y;
    }
    public void Problem70()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = add(i, sum);
        }
        System.Console.WriteLine(sum);
    }
    public void Problem69()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        for (int i = 0; i < n; i++)
        {
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            sum += numbers[i];
        }
        System.Console.WriteLine(sum);
    }
    public void Problem68()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        char[] ch = str.ToCharArray();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0, count = n - i; j < n; j++)
            {
                System.Console.Write($"{ch[count++ % 5]}");
            }
            System.Console.WriteLine();
        }
    }
    public void Problem67()
    {
        int n = int.Parse(Console.ReadLine());

        var x = n switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            5 => "May",
            6 => "June",
            7 => "July",
            8 => "August",
            9 => "September",
            10 => "October",
            11 => "November",
            12 => "December",
            _ => "none"
        };
        System.Console.WriteLine(x);
    }
    public void Problem66()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write($"*");
            }
            System.Console.WriteLine();
        }
    }
    public void Problem65()
    {
        double n = double.Parse(Console.ReadLine());

        if (n * 10000 > 100000)
        {
            System.Console.WriteLine($"{(n * 8900):F2}");
        }
        else
        {
            System.Console.WriteLine($"{(n * 10000):F2}");
        }
    }
    public void Problem64()
    {
        char[] unli = new char[10] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        char ch = char.Parse(Console.ReadLine());
        foreach (var c in unli)
        {
            if (ch == c)
            {
                System.Console.WriteLine($"unli");
                break;
            }
            else
            {
                System.Console.WriteLine("undosh");
                break;
            }
        }
    }
    public void Problem63()
    {
        int n = int.Parse(Console.ReadLine()), count = 0;
        while (true)
        {
            count++;
            n /= 10;
            if (n <= 0)
            {
                break;
            }
        }
        System.Console.WriteLine(count);
    }
    public int daraja(int n)
    {
        int count = 0;
        while (n != 0)
        {
            n /= 10;
            count++;
        }
        return count;
    }
    public bool ArmN(int n)
    {
        int sum = 0, orgN = n;
        while (orgN != 0)
        {
            sum += (int)Math.Pow(orgN % 10, daraja(n));
            orgN /= 10;
        }
        if (sum == n)
        {
            return true;
        }
        return false;
    }
    public void Problem62()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (ArmN(i))
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
    public void Problem61()
    {
        int n = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        char[] chArr = str.ToCharArray();
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (chArr[i] == 'c' && chArr[i + 1] == 'a' && chArr[i + 2] == 't')
            {
                count++;
            }
        }
        System.Console.WriteLine(count);

    }
    public void Problem60()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int max1, max2 = 0;
        max1 = numbers[0] > numbers[1] ? numbers[0] : numbers[1];
        max2 = numbers[0] < numbers[1] ? numbers[0] : numbers[1];

        foreach (var num in numbers)
        {
            max2 = num > max2 ? num : max2;
            max2 = num > max1 ? max1 : max2;
            max1 = num > max1 ? num : max1;
        }
        System.Console.WriteLine($"{max1} {max2}");
    }
    private void printStars(int num, int count)
    {
        System.Console.Write($"{num}: ");
        while (count-- > 0)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    public void Problem59()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int ones = 0, twos = 0, threes = 0;
        foreach (var num in numbers)
        {
            switch (num)
            {
                case 1:
                    ones++; break;
                case 2:
                    twos++; break;
                case 3:
                    threes++; break;
                default: break;
            }
        }
        printStars(1, ones);
        printStars(2, twos);
        printStars(3, threes);
    }
    public void Problem58()
    {
        var t = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
            }
        }
        foreach (var num in numbers)
        {
            System.Console.WriteLine($"{num}");
        }
    }
    public void Problem57()
    {
        int t = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        double aver = 0;
        foreach (var num in numbers)
        {
            aver += num;
        }
        aver /= numbers.Count();
        foreach (var num in numbers)
        {
            if (num >= aver)
            {
                System.Console.Write($"{num} ");
            }
        }
        System.Console.WriteLine();
    }
    public void Problem56()
    {
        var str = Console.ReadLine().ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[j] == ' ')
                {
                    continue;
                }
                if (str[i] > str[j])
                {
                    char temp = str[i];
                    str[i] = str[j];
                    str[j] = temp;
                }
            }
        }
        System.Console.WriteLine($"{new String(str)}");
    }
    private bool Palindrom(int n)
    {
        int rev = 0, orgN = n;
        while (n != 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        if (rev == orgN)
        {
            return true;
        }
        return false;
    }
    private int reverseDigits(int n)
    {
        int rev = 0;
        while (n != 0)
        {
            rev = rev * 10 + n % 10;
            n /= 10;
        }
        return rev;
    }
    public void Problem55()
    {
        int n = int.Parse(Console.ReadLine()), count = 0;
        while (Palindrom(n) == false)
        {
            n = n + reverseDigits(n);
            count++;
        }
        System.Console.WriteLine($"{count} {n}");
    }
    public void Problem54()
    {
        var nums = Console.ReadLine().ToCharArray().Select(i => i.ToString()).ToList();
        var counts = nums.GroupBy(i => i).Select(i => new { Num = i.ToList()[0], Count = i.Count() }).ToList();
        foreach (var n in nums)
        {
            System.Console.Write($"{counts.Where(i => i.Num == n).ToList()[0].Count}");
        }
    }
    private int getNewN(int n)
    {
        int sum = 0, orgN = n;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }
        int newN = orgN % 10 * 10 + sum % 10;
        return newN;
    }
    public void Problem53()
    {
        int n = int.Parse(Console.ReadLine()), count = 0;

        for (int newN = 0, copyN = n; ; copyN = newN)
        {
            newN = getNewN(copyN);
            count++;
            if (n == newN)
            {
                System.Console.WriteLine(count);
                break;
            }
        }
    }
    public void Problem52()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        while (true)
        {
            sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if (sum < 10)
            {
                System.Console.WriteLine($"{sum}");
                break;
            }
            n = sum;
        }
    }
    public void Problem51()
    {
        int n = int.Parse(Console.ReadLine()), count = 1;

        for (int i = 1; i <= n; i++)
        {
            int space = n - i;
            while (space-- > 0)
            {
                System.Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write($"{count++ % 10} ");
            }
            System.Console.WriteLine();
        }
    }
    public void Problem50()
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
    public void Problem49()
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
    public void Problem48()
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
    public void Problem47()
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
    public void Problem46()
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
    public void Problem45()
    {
        string str = Console.ReadLine();

        foreach (var element in str)
        {
            System.Console.Write($"{Convert.ToInt64(element):X} "); ;
        }
        System.Console.WriteLine();
    }
    public void Problem44()
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
    public int Collatz(long n)
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
    public void Problem43()
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
    public void Problem42()
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
    public void Problem41()
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
    public void Problem40()
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

    public void Problem39()
    {
        int n = int.Parse(Console.ReadLine()), sum = 0;
        var nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        foreach (var num in nums)
        {
            sum += (int)Math.Pow(num, 3);
        }
        System.Console.WriteLine(sum);
    }

    public void Problem38()
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
    public void Problem37()
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
    public void Problem36()
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
    public void Problem35()
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
    public void Problem34()
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
    public void Problem33()
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
    public void Problem32()
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
    public void Problem31()
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
    public void Problem30()
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
    public void Problem29()
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
    public void Problem28()
    {
        int n = int.Parse(Console.ReadLine());

        System.Console.WriteLine((n >= 0 && n < 40 ? "tashqarida o'yna" : "ichkarida o'yna"));
    }
    public void Problem27()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        if (numbers[0] == 0)
        {
            numbers[0] = 24;
        }
        int res = numbers[0] * 60 + numbers[1] - 45;

        System.Console.WriteLine($"{res / 60} {res % 60}");
    }
    public void Problem26()
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();

        System.Console.WriteLine((numbers[0] > numbers[1] ? $"{numbers[0] / numbers[1]}\n{numbers[0] % numbers[1]}" : $"{numbers[1] / numbers[0]}\n{ numbers[1] % numbers[0] }"));
    }
    public void Problem25()
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
    public void Problem24()
    {
        int n = int.Parse(Console.ReadLine());

        System.Console.WriteLine((n % 2 == 0 ? "even" : "odd"));
    }
    public void Problem23()
    {
        char ch = char.Parse(Console.ReadLine());

        System.Console.WriteLine(((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') ? 1 : 0));
    }
    public void Problem22()
    {
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine((n >= 20 && n <= 30 ? 1 : 0));
    }
    public void Problem21()
    {
        double N = double.Parse(Console.ReadLine());

        double PI = 3.14;
        double R = N / (2 * PI);
        double area = PI * Math.Pow(R, 2);

        Console.WriteLine(Math.Round(area));
    }
}