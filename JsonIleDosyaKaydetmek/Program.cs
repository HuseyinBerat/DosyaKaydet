using Newtonsoft.Json;
using System;

namespace JsonIleDosyaKaydetmek
{
    class Program
    {
        string dosyayol = @"C:\Users\Pc\Desktop\resim\Girdi\girdi.txt";
        string kayityeri = @"C:\Users\Pc\Desktop\resim\cikti\cikti.txt";
        static void Main(string[] args)
        {
            Program p = new Program();
            p.baslat();
        }
        void baslat()
        {
            veri vr = new veri() { resim = System.IO.File.ReadAllBytes(dosyayol) };
            string jveri = JsonConvert.SerializeObject(vr);
            Console.WriteLine(jveri);
            veri rveri = JsonConvert.DeserializeObject<veri>(jveri);
            System.IO.File.WriteAllBytes(kayityeri, rveri.resim);
            Console.Read();
        }
    }
    class veri
    {
        public byte[] resim { get; set; }
    }
}
