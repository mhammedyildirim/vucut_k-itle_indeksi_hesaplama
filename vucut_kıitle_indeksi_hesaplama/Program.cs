using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vucut_kıitle_indeksi_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vücut Kütle Indexi(bmi): ağırlık / (boy * boy) olarak hesaplanmaktadır. Ağırlık kg cinsinden boy ise metre cinsindendir.Ağırlık ve Kilo değerlerini kullanıcıdan alarak hesaplayan ve
            (bmi< 18.5) ise “1düşük ağırlık”
            (18.5 < bmi < 25)  ise “normal ağırlık”
            (25 < bmi < 30) ise “1.Dereceden obesite”
            (30 < bmi < 35) ise “2.Dereceden obesite”
            (35 < bmi < 40) ise “3.Dereceden obesite” 
            (bmi > 40) ise “4.Dereceden obesite” 
            Şeklinde çıktı veren bir console uygulamayı c# ile yazınız
            */

            double agirlik = 0;
            double boy = 0;
            double bmi = 0;
            Console.WriteLine("Ağırlığınızı giriniz(kg):");
            agirlik = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz(metre cinsinden ör: 1,83):");
            boy = Convert.ToDouble(Console.ReadLine());

            bmi = agirlik / (boy * boy);

            if (bmi < 18.5)
            {
                Console.WriteLine("Düşük Ağırlık");
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                Console.WriteLine("Normal Ağırlık");
            }
            else if (bmi > 25 && bmi < 30)
            {
                Console.WriteLine("1.dereceden Obezite");
            }
            else if (bmi > 30 && bmi < 35)
            {
                Console.WriteLine("2.dereceden Obezite");
            }
            else if (bmi > 35 && bmi < 40)
            {
                Console.WriteLine("3.dereceden Obezite");

            }
            else if (bmi > 40)

            {
               Console.WriteLine("4.dereceden Obezite");
            }
            Console.ReadKey();
        }
            
    }
}
