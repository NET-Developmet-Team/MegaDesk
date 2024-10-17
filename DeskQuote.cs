using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Alexander
{
    public class DeskQuote
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RushOrderDays { get; set; }
        public int surfaceAreaSurcharge { get; set; }
        public int surfaceArea { get; set; }
        public int materialPrice { get; set; }
        public int rushOrderPrice { get; set; }
        public int drawerPrice { get; set; }
        public int totalPrice { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk { get; set; }
        public int BaseDeskPrice = 200;

        public DeskQuote(string firstName, string lastName, Desk desk, int rushOrderDays)
        {
            FirstName = firstName;
            LastName = lastName;
            RushOrderDays = rushOrderDays;
            QuoteDate = DateTime.Now;
            Desk = desk;
            CalculateTotalPrice();
        }

        public void CalculateTotalPrice()
        {
            (surfaceAreaSurcharge, surfaceArea) = CalculateSurfaceAreaPrice(Desk.Width, Desk.Depth);
            materialPrice = CalculateMaterialCost(Desk.Material);
            rushOrderPrice = CalculateRushOrderPrice(surfaceArea, RushOrderDays);
            drawerPrice = CalculateDrawerPrice(Desk.NumberOfDrawers);

            totalPrice = (surfaceAreaSurcharge + materialPrice + rushOrderPrice + drawerPrice + BaseDeskPrice);
        }

        private (int surfaceAreaSurcharge, int surfaceArea) CalculateSurfaceAreaPrice(int width, int depth)
        {
            int surfaceArea = width * depth;
            int surfaceAreaSurchage = 0;

            if (surfaceArea > 1000)
            {
                surfaceAreaSurchage = surfaceArea - 1000;
            }

            return (surfaceAreaSurchage, surfaceArea);
        }

        private int CalculateMaterialCost(DesktopMaterial material)
        {
            switch (material)
            {
                case DesktopMaterial.Oak: return 200;
                case DesktopMaterial.Laminate: return 100;
                case DesktopMaterial.Pine: return 50;
                case DesktopMaterial.Rosewood: return 300;
                case DesktopMaterial.Veneer: return 125;
                default: return 0;
            }
        }

        private int CalculateRushOrderPrice(int surfaceArea, int rushOrderDays)
        {
            

            // If standard production time, don't charge extra
            if (rushOrderDays == 14) { return 0; }

            // returns the list as [60, 70, 80, 40, 50, 60, 30, 35, 40]
            var rushPrices = ReadFromFile("rushOrderPrices.txt");

            if (rushOrderDays == 3)
            {
                if (surfaceArea < 1000) { return rushPrices[0]; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return rushPrices[1]; }
                if (surfaceArea > 2000) { return rushPrices[2]; }
            }

            if (rushOrderDays == 5)
            {
                if (surfaceArea < 1000) { return rushPrices[3]; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return rushPrices[4]; }
                if (surfaceArea > 2000) { return rushPrices[5]; }
            }

            if (rushOrderDays == 7)
            {
                if (surfaceArea < 1000) { return rushPrices[6]; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return rushPrices[7]; }
                if (surfaceArea > 2000) { return rushPrices[8]; }
            }
            return 0;

        }

        private int CalculateDrawerPrice(int numberOfDrawers)
        {
            int drawerPrice = numberOfDrawers * 50;
            return drawerPrice;

        }

        public string GetMaterialName()
        {
            return Desk.Material.ToString();
        }

        public List<int> ReadFromFile(string fileName)
        {
            string filePath = Path.Combine(Application.StartupPath, "Assets", fileName);

            var prices = new List<int>();
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    prices.Add(int.Parse(line));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading file: " + e.Message);
            }

            return prices;

        }

    }

}
