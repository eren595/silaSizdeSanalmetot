using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace silaSizdeSanalmetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.Oku();

            Dergi dergi = new Dergi();
            dergi.Oku();

            Ansiklopedi ansiklopedi = new Ansiklopedi();
            ansiklopedi.Oku();
        }
    }
    public interface Okuyabilir
    {
        void Oku();
    }
    public class Kitap : Okuyabilir
    {
        public void Oku()
        {
            Console.WriteLine("Kitap okunuyor...");
        }
    }
    public class Dergi : Okuyabilir
    {
        public void Oku()
        {
            Console.WriteLine("Dergi okunuyor...");

        }
    }
    public class Ansiklopedi : Okuyabilir
    {
        public void Oku()
        {
            Console.WriteLine("Ansiklopedi okunuyor...");
        }
    }
}
