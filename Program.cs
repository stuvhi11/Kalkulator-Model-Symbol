// See https://aka.ms/new-Console-template for more information
//Console.WriteLine("Hello, World!");
namespace kalkulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ulang = "";
            do
            {
                Console.WriteLine("Selamat Datang di Program Perhitungan");
                Console.Write("Masukkan angka pertama = ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua = ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pilih bentuk opersi (+, -, :, *)");
                Console.Write("Masukkan bentuk operasi yang di ingin kan? ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        int plus = num1 + num2;
                        Console.Write($"Hasil dari {num1} {op} {num2} = " + plus);
                        break;
                    case "-":
                        int mins = num1 - num2;
                        Console.Write($"Hasil dari {num1} {op} {num2} = " + mins);
                        break;
                    case "*":
                        int kali = num1 * num2;
                        Console.Write($"Hasil dari {num1} {op} {num2} = " + kali);
                        break;
                    case ":":
                        int bagi = num1 / num2;
                        Console.Write($"Hasil dari {num1} {op} {num2} = " + bagi);
                        break;
                    default:
                        Console.WriteLine("Mohon maaf yang anda inputkan tidak ada di Program Perhitungan");
                        break;
                }
                Console.WriteLine("\nApakah anda akan melakukan Program Perhitungan lagi? (ya/tidak)");
                ulang = Console.ReadLine();
            } while (ulang == "ya");
            Console.WriteLine("Terimakasih telah melakukan Program Perhitungan\n\t\tHave nice day !!");
        }
    }
}