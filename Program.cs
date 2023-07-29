using System;
namespace trycatch
{
    class programme
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayi: ");
                int sayi =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayi: "+ sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }

            //finally
            //{
             //   Console.WriteLine("İşlem tamamlandi");    
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger");
                Console.WriteLine(ex);
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kucuk ya da buyuk sayi");
                Console.WriteLine(ex);
            }

            finally
            {
                Console.WriteLine("islem bitti");
            }
        }
    }
}
