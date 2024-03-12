﻿using System;

namespace BaiTapVeNha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không. Hiển thị kết quả ra màn hình.

            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(n%3 == 0 ? $"{n} chia het cho 3" : $"{n} khong chia het cho 3");
            */

            //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.
            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++){
                Console.WriteLine($"Bang cuu chuong thu {i}: ");
                for (int j = 1; j <= 10; j++){
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
            */

            //Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.
            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int mul = 1;
            for (int i = 1; i <= n; i++){
                mul *= i;
            }
            Console.WriteLine($"Ket qua cua {n}! la: {mul}");
            */

            //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.
            //Hiển thị kết quả đạt được ra màn hình.

            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(n);
            if (sqrt * sqrt == n){
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else{
                Console.WriteLine($"{n} khong phai la so chinh phuong");
            }

            // int i = 1;
            // while (i * i <= n){
            //     if (i * i == n){
            //         Console.WriteLine($"{n} la so chinh phuong");
            //         return;
            //     }
            //     i++;
            // }
            // Console.WriteLine($"{n} khong phai la so chinh phuong");
            */


            //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong
            // tháng ra màn hình. 
            /*
            Console.Write("\nNhap vao thang: ");
            int month = int.Parse(Console.ReadLine());

            switch (month){
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine($"Thang {month} co 31 ngay");
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine($"Thang {month} co 30 ngay");
                    break;
                case 2:
                    Console.WriteLine($"Thang {month} co 28 hoac 29 ngay");
                    break;
                default:
                    Console.WriteLine("Thang khong hop le");
                    break;
            }
            */

            //Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị
            // kết quả ra màn hình. S = 1 + 2^2 + 3^3 + ... + n^n
            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (int)Math.Pow(i, i);
            }
            Console.WriteLine($"Ket qua la: {sum}");
            */

            //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị
            // kết quả ra màn hình.
            /*
            Console.Write("\nNhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Tong cac so le tu 1 den {n} la: {sum} ");
            */
            
            //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            //Sum of prime numbers from 1 to n
            
            /*
             Console.Write("\nNhap vao so nguyen n: ");
             int n = int.Parse(Console.ReadLine());
             int sum = 0;
             if (n < 2)
             {
                 Console.WriteLine("Khong co so nguyen to nao");
                 return;
             }
             for (int i = 2; i <= n; i++)
             {
                 bool isPrime = true;
                 for (int j = 2; j <= Math.Sqrt(i); j++)
                 {
                     if (i % j == 0)
                     {
                         isPrime = false;
                         break;
                     }
                 }
                 if (isPrime)
                 {
                     sum += i;
                     Console.Write($"{i} ");
                 }
             }
             Console.WriteLine($"\nTong cac so nguyen to tu 1 den {n} la: {sum} ");
            */     
            
            
            //Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ,
            // nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới. Có thể thử vẽ thêm với
            // hình tam giác đều, tam giác xoay ngược.
            
            /*
            Console.Write("Nhap vao so hang: ");
            int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     for(int j = 1; j <= i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }
            
            //tam giac xoay nguoc
            for (int i = n; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //tam giac deu: n = 4
            //   *      khoang trang la 3
            //  * *     khoang trang la 2
            // * * *    khoang trang la 1
            //* * * *   khoang trang la 0

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
            }
            */
            
            
            //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
            //Vi du n = 5 => 0 1 1 2 3
            //Cho n1 = 0, n2 = 1
            //n3 = n2 + n1, n2 =n1
            
            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0) return;
            int n1 = 0, n2 = 1, n3;
            Console.Write($"Day Fibonacci tu 1 den {n} la: ");
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine();
                
            
            
            Console.ReadLine();
        }
    }
}