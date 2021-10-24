using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyazKutuTesti
{
   public class Program
    {
        //birinci soru
       public static int[] Quick_Sort(int[] dizi, int sol, int sag)
        {
            //Pivot olarak son elemanı seç
            int p = dizi[sag - 1];
            int i = sol; 
            int j = sag - 2; 
            int temp = 0;

            if (sag - sol > 2)
            {
                while (i < j)
                {
                    //Sol kısımdaki eleman pivot elemandan büyükse seç
                    while (dizi[i] < p) { i++; }

                    //Sağ kısımdaki eleman pivot elemandan küçükse seç
                    while (j > 0 && dizi[j] > p) { j--; }

                    if (i < j)
                    {
                        temp = dizi[i];
                        dizi[i++] = dizi[j];
                        dizi[j--] = temp;
                    }
                }
            }

            //Pivot elemanı karşılaştır ve yer değiştir
            if (p < dizi[i])
            {
                temp = dizi[i];
                dizi[i] = dizi[sag - 1];
                dizi[sag - 1] = temp;
            }

            //Solda eleman varsa
            if (i - sol > 1)
                dizi = Quick_Sort(dizi, sol, i);

            //Sağda eleman varsa
            if (sag - (i + 1) > 1)
                dizi = Quick_Sort(dizi, i + 1, sag);

            return dizi;
        }

        //üçüncü soru
        public void maxsum(int maxint, int value)
        {
            int result = 0;
            int i = 0;

            if (value < 0)
            {
                value = -value;
            }
            while ((i<value) && (result <= maxint))
            {
                i = i + 1;
                result = result + i;
            }
            if (result <= maxint)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("too large");
            }
        }

        static void Main(string[] args)
        {
            //birinci soru
            try
            {
                int[] d = Quick_Sort(new int[] { 76, 6, 4, 19, 50 }, 0, 5);
                //Konsola yaz
                for (int i = 0; i < d.Length; i++)
                {
                    Console.Write(d[i] + " ");
                }
            }
            catch(Exception ex)
            {

            }

            Console.WriteLine("\n");

            // ikinci soru
            try
            {
                int value = 50;
                int kalan;
                int temp;
                string topla = "";
                if (value < 0)
                {
                    string binary = Convert.ToString(value, 2);
                    Console.WriteLine(binary);
                }
              
                if (value >= 0)
                {
                  
                    while (value >= 0)
                    {
                        kalan = value % 2;
                        value = value / 2;
                        topla += Convert.ToString(kalan);

                        if (value == 0 || value == 1)
                        {
                            topla += value;
                            break;
                        }
                    }
                    for (int i = topla.Length - 1; i >= 0; i--)
                    {
                        Console.Write(topla[i]);
                    }
                }

               
            }
            catch(Exception ex)
            {

            }

            Console.WriteLine("\n");

            //üçüncü soru
            try
            {
                Program pr = new Program();
                pr.maxsum(10, 2);

            }catch(Exception ex)
            {

            }

            Console.WriteLine("\n");

            //dördüncü soru
            try
            {
                int a;
                int b;
                int count = 0;
                a = Convert.ToInt32(Console.ReadLine());
                b= Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    while (b > 0)
                    {
                        b = b - 1;
                        count++;
                    }
                }
                else if (a > 0)
                {
                    while (b < 0)
                    {
                        b = b + 1;
                        count--;
                    }
                }
                else
                {
                    a = b;
                }
                Console.WriteLine("a: " + a + " b: " + b + " count: " + count);

            }
            catch(Exception ex)
            {

            }
            
            Console.ReadKey();
        }
    }
}
