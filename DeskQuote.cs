using MegaDesk_Alexander;
using System.IO;
using System.Windows.Forms;
using System;

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
    public string FullName { get { return FirstName + " " + LastName; } }
    public DateTime QuoteDate { get; set; }
    public Desk Desk { get; set; }
    public int BaseDeskPrice = 200;

    // Two-dimensional array to hold rush order prices
    private int[,] rushOrderPrices;

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
        int surfaceAreaSurcharge = 0;

        if (surfaceArea > 1000)
        {
            surfaceAreaSurcharge = surfaceArea - 1000;
        }

        return (surfaceAreaSurcharge, surfaceArea);
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
        // Populate the rush order prices array if it's null
        if (rushOrderPrices == null)
        {
            GetRushOrder("rushOrderPrices.txt");
        }

        // If standard production time, don't charge extra
        if (rushOrderDays == 14) { return 0; }

        // Logic to select correct price based on rushOrderDays and surfaceArea
        int rowIndex = 0;

        switch (rushOrderDays)
        {
            case 3: rowIndex = 0; break;
            case 5: rowIndex = 1; break;
            case 7: rowIndex = 2; break;
        }

        if (surfaceArea < 1000)
        {
            return rushOrderPrices[rowIndex, 0];
        }
        else if (surfaceArea <= 2000)
        {
            return rushOrderPrices[rowIndex, 1];
        }
        else
        {
            return rushOrderPrices[rowIndex, 2];
        }
    }

    private int CalculateDrawerPrice(int numberOfDrawers)
    {
        return numberOfDrawers * 50;
    }

    public string GetMaterialName()
    {
        return Desk.Material.ToString();
    }

    /// <summary>
    /// Reads rush order prices from a file and populates the two-dimensional array.
    /// </summary>
    public void GetRushOrder(string fileName)
    {
        string filePath = Path.Combine(Application.StartupPath, "Assets", fileName);
        rushOrderPrices = new int[3, 3];

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Populate the 2D array (3 rows and 3 columns)
            int index = 0;
            for (int i = 0; i < 3; i++)  // Rows (3, 5, 7 days)
            {
                for (int j = 0; j < 3; j++)  // Columns (based on surface area)
                {
                    rushOrderPrices[i, j] = int.Parse(lines[index]);
                    index++;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error reading rush order prices: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
