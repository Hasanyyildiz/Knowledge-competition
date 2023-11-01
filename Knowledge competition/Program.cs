using System;

namespace bilgiYarismasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bilgi Yarışmasına Hoş geldiniz ---");
            Console.WriteLine();
            Console.WriteLine("-- Kurallar -- ");
            Console.WriteLine();
            Console.WriteLine("-> Yarışmamız 3 sorudan oluşmaktadır");
            Console.WriteLine("-> Her soru 4 şıktan oluşmaktadır");
            Console.WriteLine("-> Soruyu bilemezseniz diğer soruya geçemezsiniz");
            Console.WriteLine("   ve yarışmanız sonlanır");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.ReadKey();
            Console.WriteLine();

            soru1 soru1 = new soru1();
            soru1.Questions();
            Console.WriteLine("");
            Console.Write("Cevabınız: ");
            string cevap1 = Console.ReadLine();


            switch (cevap1)
            {
                case "A":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;
                case "C":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;
                case "D":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;
                
            }

            if (cevap1 != "B")
            {
                return;
            }
            else
            {
                Console.WriteLine("Doğru Cevap");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            soru2 soru2 = new soru2();
            soru2.Questions();
            Console.WriteLine("");
            Console.Write("Cevabınız: ");
            string cevap2 = Console.ReadLine();

            switch (cevap2)
            {
                case "A":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;
                case "B":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;
                case "D":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.ReadKey();
                    break;

            }

            if (cevap2 != "C")
            {
                return;
            }
            else
            {
                Console.WriteLine("Doğru Cevap");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            soru3 soru3 = new soru3();
            soru3.Questions();
            Console.WriteLine("");
            Console.Write("Cevabınız: ");
            string cevap3 = Console.ReadLine();

            switch (cevap3)
            {
                case "B":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case "C":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                case "D":
                    Console.WriteLine("Cevabınız Yanlış");
                    Console.WriteLine();
                    Console.WriteLine("Tekrar Deneyiniz...");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;

            }

            if (cevap3 != "A")
            {
                return;
            }
            else
            {
                Console.WriteLine("Doğru Cevap");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("--- YARIŞMAYI BAŞARIYLA BİTİRDİNİZ ---");

            Console.ReadKey();

        }
    }
}

