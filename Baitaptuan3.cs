namespace Baitapvenha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baitap01();
            Baitap02();
            Baitap03();
            Baitap04();
            Baitap05();
            Baitap06();
            Baitap08();
            Baitap09();
            Baitap10();
        }
        static void Baitap01()
        {
            Console.WriteLine("Nhap vao so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int tong = a + b;
            Console.WriteLine("Tong cua a,b la: " + tong);
        }
        static void Baitap02()
        {
            Console.WriteLine("Nhap vao so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
        static void Baitap03()
        {
            Console.WriteLine("Nhap vao so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a * b;
            Console.WriteLine("Ket qua cua phep nhan: " + result);
        }
        static void Baitap04()
        {
            Console.WriteLine("Nhap vao so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double met = feet * 0.3048;
            Console.WriteLine(feet + " feet bang " + met + " met ");
        }
        static void Baitap05()
        {
            Console.WriteLine("Chuong trinh chuyen doi nhiet do.");
            Console.WriteLine("1.Chuyen tu Celsius sang Fahrenheit.");
            Console.WriteLine("2.Chuyen tu Fahrenheit sang Celsius.");
            Console.Write("Vui long chon che do ma ban muon chon (1) hoac (2)! : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Nhap vao so Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Nhap vao so Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");

            }
            else
            {
                Console.WriteLine("Lua chon cua ban khong the thuc hien! ");
            }
        }
        static void Baitap06()
        {
            Console.WriteLine("Kích thước của bool: " + sizeof(bool) + " byte");
            Console.WriteLine("Kích thước của byte: " + sizeof(byte) + " byte");
            Console.WriteLine("Kích thước của sbyte: " + sizeof(sbyte) + " byte");
            Console.WriteLine("Kích thước của char: " + sizeof(char) + " byte");
            Console.WriteLine("Kích thước của short: " + sizeof(short) + " byte");
            Console.WriteLine("Kích thước của ushort: " + sizeof(ushort) + " byte");
            Console.WriteLine("Kích thước của int: " + sizeof(int) + " byte");
            Console.WriteLine("Kích thước của uint: " + sizeof(uint) + " byte");
            Console.WriteLine("Kích thước của long: " + sizeof(long) + " byte");
            Console.WriteLine("Kích thước của ulong: " + sizeof(ulong) + " byte");
            Console.WriteLine("Kích thước của float: " + sizeof(float) + " byte");
            Console.WriteLine("Kích thước của double: " + sizeof(double) + " byte");
            Console.WriteLine("Kích thước của decimal: " + sizeof(decimal) + " byte");
        }
        static void Baitap08()
        {
            const double Pi = 3.14159;
            Console.WriteLine("Vui lòng nhập giá trị của bán kính: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double S = Pi * Math.Pow(r, 2);
            Console.WriteLine($"Dien tich hinh tron: {Math.Round(S, 2)}");
        }
        static void Baitap09()
        {
            Console.WriteLine("Nhap vao gia tri cua canh ");
            double canh = Convert.ToDouble(Console.ReadLine());
            double CalSquare = canh * canh;
            Console.WriteLine($"Dien tich hinh vuong = {Math.Round(CalSquare, 1)}");
        }
        static void Baitap10()
        {
            Console.WriteLine("Nhap vao so ngay can chuyen doi: ");
            int tongsongay = Convert.ToInt32(Console.ReadLine());
            int nam = tongsongay / 365;
            int songayconlaisaunam = tongsongay % 365;
            int tuan = songayconlaisaunam / 7;
            int songayconlaisautuan = songayconlaisaunam % 7;
            Console.WriteLine($"{tongsongay} tuong duong voi {nam} nam va {tuan} tuan va {songayconlaisautuan} ngay");

        }
    }
}