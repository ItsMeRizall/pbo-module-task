using Class_Laptop;
using Class_VGA;
using Class_Processor;

namespace Modul_Praktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            /*Variabel Laptop 1*/
            Laptop laptop1 = new Laptop();

            laptop1.merk = new ASUS().merk;
            laptop1.type = new Vivobook().type;
            laptop1.processor = new CoreI5().type;
            laptop1.vga = new Vga().merk;
            /*laptop1.ngoding();  ==> Karena method ngoding tidak terdefinisi dalam class Laptop*/

            /*Variabel Laptop 2*/
            Laptop laptop2 = new Laptop();

            laptop2.merk = new Lenovo().merk;
            laptop2.type = new IdeaPad().type;
            laptop2.processor = new Ryzen().type;
            laptop2.vga = new Class_VGA.AMD().merk ;
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            /*Variabel predator*/
            Predator predator = new Predator();

            predator.vga = new Class_VGA.AMD().merk;
            predator.processor = new CoreI7().type;
            predator.BermainGame();

            /*Variabel Acer*/
            ACER acer = new ACER();

            acer.merk = new Predator().merk;
            /*acer.BermainGame();  ==> Karena dalam class acer tidak memiliki method BermainGame()*/
        }
    }
}

namespace Class_Processor
{
    public class Processor
    {
        public string? merk;
        public string? type;
    }

    public class Intel : Processor {
    public Intel() {
            base.merk = "Intel";
        }
    }

    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.type = "Core I3";
        }
    }

    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.type = "Core I5";
        }
    }

    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.type = "Core I7";
        }
    }

    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.type = "RYZEN";
        }
    }

    public class Athlon : AMD
    {
        public Athlon()
        {
            base.type = "ATHLON";
        }
    }

}

namespace Class_VGA
{
    public class Vga
    {
        public string? merk;
    }

    public class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    public class AMD : Vga
    {
        public AMD()
        {
            base.merk = "Nvidia";
        }
    }
}

namespace Class_Laptop
{
    public class Laptop
    {
        public string? merk;
        public string? type;
        public string? vga;
        public string? processor;

        /*public string? merk;
        public string? type;
        public Vga vga;
        public Processor processor;*/  /*Ini Adalah Soal Awal*/

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {type} Menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {type} Mati");
        }
    }

    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }

    public class ACER : Laptop
    {
        public ACER() { base.merk = "ACER"; }
    }

    public class Lenovo : Laptop { public Lenovo() { base.merk = "Lenovo"; } }

    public class ROG : ASUS
    {
        public ROG() { base.type = "ROG"; }
    }

    public class Vivobook : ASUS
    {
        public Vivobook() { base.type = "Vivobook";}

        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi !!");
        }

    }

    public class Swift : ACER
    {

        public Swift() { base.type = "Swift"; }
    }

    public class Predator : ACER
    {
        public Predator() { base.type = "Predator"; }

        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {type} sedang bermain game");
        }

    }

    public class IdeaPad : Lenovo
    {
        public IdeaPad() { base.type = "IdeaPad"; }
    }

    public class Legion : Lenovo
    {
        public Legion() { base.type = "Legion"; }
    }
}