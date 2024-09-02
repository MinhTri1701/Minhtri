using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace Baitaptuan4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex2:
            Baitap01();
            Baitap02();
            Baitao03();
            Baitap04();
            Baitap05();
            Baitap06();
            Baitap07();
            //Ex1:
            Baitap001();
            Baitap002();
            Baitap003();
        }
        static void Baitap01()
        {
            int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];

            }
            double average = (double)sum / 10;
            Console.WriteLine($"Tong cua 10 so nhap vao la: {sum}");
            Console.WriteLine($"Trung binh cong cua 10 so nhap vao la: {average}");
        }
        static void Baitap02()
        {
            do
            {
                Console.WriteLine("Nhap cac canh cua tam giac: ");

                Console.WriteLine("Nhap canh a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Nhap canh b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Nhap canh c: ");
                double c = Convert.ToDouble(Console.ReadLine());


                //Kiem tra tinh hop le cua tam giac
                if (a + b > c && a + c > b && b + c > a)
                {
                    //Kiem tra tam giac deu
                    if (a == b && b == c)
                    {
                        Console.WriteLine("Day la tam giac deu ");
                    }
                    //Kiem tra tam giac can 
                    else if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Day la tam giac can ");
                    }
                    else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b))
                    {
                        Console.WriteLine("Day la tam giac vuong: ");
                    }

                    else

                        Console.WriteLine("Day la tam giac thuong!");
                }
                else

                    Console.WriteLine("Ba canh nay khong the tao thanh tam giac");


                Console.Write("Ban co muon tiep tuc kiem tra tam giac khong? <Y/N>");
                string res = "" + Console.ReadLine();
                if (res.ToUpper().Equals("N"))
                {
                    Console.WriteLine("Qua trinh kiem tra ket thuc:");
                    break;
                }
            } while (true);
        }
        static void Baitao03()
        {

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"\nBang nhan cua {i}\n");

                for (int j = 1; j <= 10; j++)

                    Console.WriteLine($"{i,2} * {j,2} = {i * j,2}");
            }
            Console.WriteLine();
        }
        static void Baitap04()
        {
            Console.WriteLine("Nhap vao so dong cua tam giac 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhap vao so dong cua tam giac 3: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            for (int i = 1; c <= m; i++)
            {
                for (int k = m; k > i; k--)//nhap k=5, k>1 vì k chạy ngược từ dưới lên trên k giảm
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i && c <= m; j++)
                {
                    Console.Write(c + " ");
                    c++;
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Nhap vao so dong cua tam giac 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int v = 1;
            for (int i = 1; v <= b; i++)
            {
                for (int j = 1; j <= i && v <= b; j++)
                {
                    Console.Write(v + " ");
                    v++;
                }
                Console.WriteLine();
            }
        }
        static void Baitap05()
        {
            Console.Write("Nhap vao so luong so hang: ");
            int n = int.Parse("" + Console.ReadLine());

            double tongchuoi = 0.0;
            Console.WriteLine("Chuoi ");
            for (int i = 1; i <= n; i++)
            {
                double soHang = 1.0 / i;
                tongchuoi += soHang;
                Console.Write($"{soHang:F2}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine($"\n\nTong cua chuoi voi {n} so hang: {tongchuoi:F2}");



        }
        static void Baitap06()
        {
            Console.Write("Nhap vao 1 so  ");
            int n = int.Parse("" + Console.ReadLine());
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
            if (tong == n)
            {
                Console.WriteLine(n + " la so hoan hao ");
            }
            else
            {
                Console.WriteLine(n + " khong phai so hoan hao ");
            }
        }
        static void Baitap07()
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Khong phai so nguyen to");
            }
            else
            {
                bool SoNT = true;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        SoNT = false;
                        break;
                    }
                }
                if (SoNT)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                }
                else
                {
                    Console.WriteLine($"{n} khong phai so nguyen to");
                }

            }
        }
        static void Baitap001()
        {
            Console.WriteLine("Nhap vao 1 so: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Day la so chan ");
            }
            else
            {
                Console.WriteLine("Day la so le");
            }
        }
        static void Baitap002()
        {
            Console.Write("Nhap vao so thu 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao so thu 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
                if (c > max)
                {
                    max = c;
                }
            }
            Console.WriteLine($"So lon nhat la: {max} ");

        }
        static void Baitap003()
        {
            Console.Write("Nhập tọa độ x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập tọa độ y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong Quadrant I (Tứ giác I).");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong Quadrant II (Tứ giác II).");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong Quadrant III (Tứ giác III).");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong Quadrant IV (Tứ giác IV).");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Điểm nằm trên trục Y.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Điểm nằm trên trục X.");
            }
            else
            {
                Console.WriteLine("Điểm nằm tại gốc tọa độ.");
            }
        }
    }
}
     
