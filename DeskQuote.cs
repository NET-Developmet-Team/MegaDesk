using System;
using System.Collections.Generic;
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

            if (rushOrderDays == 3)
            {
                if (surfaceArea < 1000) { return 60; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return 70; }
                if (surfaceArea > 2000) { return 80; }
            }

            if (rushOrderDays == 5)
            {
                if (surfaceArea < 1000) { return 40; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return 50; }
                if (surfaceArea > 2000) { return 60; }
            }

            if (rushOrderDays == 7)
            {
                if (surfaceArea < 1000) { return 30; }
                if ((surfaceArea >= 1000) && (surfaceArea <= 2000)) { return 35; }
                if (surfaceArea > 2000) { return 40; }
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
    }

}
