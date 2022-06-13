using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt5.Tridy
{
    internal class Tovarna
    {
        Dictionary<string, string> modely = new Dictionary<string, string>();
        public Tovarna()
        {
            modely.Add("Model Y", "https://burzovnisvet.cz/wp-content/uploads/2021/09/tesla-model-Y.jpg");
            modely.Add("Model 3", "https://cdn.24net.cz/5/obrazek/tesla-model-3-2138");
            modely.Add("Model X", "https://static.driveto.cz/images/full/2/b/2b234573-f8ff-42da-b72b-d7c6757e0da7.jpg");
            modely.Add("Model S", "https://d62-a.sdn.cz/d_62/c_img_gS_c/OsCGz/0x0-models-05.jpeg?fl=cro,0,0,976,549%7Cres,1200,,1%7Cwebp,75");
            modely.Add("Cybertruck", "https://auto-mania.cz/wp-content/uploads/2019/11/Tesla-Cybertruck-6.jpg");
        }
        public void Menu()
        {
            Console.WriteLine("Vítejte v továrně!");
            Console.WriteLine("V nabídce máme:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Model S");
            Console.WriteLine("Model 3");
            Console.WriteLine("Model X");
            Console.WriteLine("Model Y");
            Console.WriteLine("Cybertruck");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Chci zobrazit poslední vytvořené auto");
            Console.WriteLine("2. chci vytvořit nové auto");
        }


        public Auto VytvorAuto()
        {
            Console.Clear();
            Auto vyrobeneAuto = new Auto();
            Console.WriteLine("Zadej název modelu");
            string model = Console.ReadLine();
            Console.WriteLine("Zadej počet sedadel");
            int pocetSedadel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej druh pohonu (elektrický/hybridní)");
            string druhMotoru = Console.ReadLine();
            Console.WriteLine("Zadej cenu");
            int cena = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("chcete vytvořené vozidlo zobrazit? Y/N");
            string rozhodnuti = Console.ReadLine();

            return vyrobeneAuto;
        }

        public void VytvorStranku(Auto vyrobeneAuto)
        {
            string html = $@"
        < html >
        < body >
        < h1 > Továrna na auta</ h1 >
        < h2 style = 'color:blue;' >{ vyrobeneAuto.Znacka}</h2>
        <h2>{vyrobeneAuto.Model}</h2>
        <h2>Počet sedaček: { vyrobeneAuto.PocetSedadel}</h2>
        <h2>Druh pohonu: { vyrobeneAuto.DruhPohonu}</h2>
        <img src='{vyrobeneAuto.Obrazek}'>
        <h3>Rok výroby: { vyrobeneAuto.RokVyroby}</h3>
        <hr>
        <div>
            Cena: <h4 style='color: orange;' >{ vyrobeneAuto.Cena}</ h4 >
        </ div >
        </ body >
        </ html >";
            File.WriteAllText("index.html", html);
        }
        public void ZobrazStranku(string adresaSouboru)
        {
            var process = new System.Diagnostics.ProcessStartInfo();
            process.UseShellExecute = true;
            process.FileName = adresaSouboru;
            System.Diagnostics.Process.Start(process);
        }
    }
    
}
