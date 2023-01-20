using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Dias.Resources
{
    public class DeskQuote
    {
        public Desk desk;
        public string customerName;
        public RushOrderType rushOrder;
        public DateTime date;
        public float quote
        {
            get
            {
                return calculateQuote();
            }
        }
  
        public DeskQuote(Desk desk, string customerName, RushOrderType rushOrder)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.rushOrder = rushOrder;
            this.date = DateTime.Now;
        }
        public DeskQuote(string str)
        {
            var deskQuoteStr = str.Split(',');
            this.desk = new Desk($"{deskQuoteStr[0]},{deskQuoteStr[1]},{deskQuoteStr[2]},{deskQuoteStr[3]}");
            this.customerName = deskQuoteStr[4];
            this.rushOrder = (RushOrderType)int.Parse(deskQuoteStr[5]);
            this.date = DateTime.Parse(deskQuoteStr[6]);
        }
        public override string ToString()
        {
            return $"{desk},{customerName},{(int)rushOrder},{date}";
        }
        private int calculateQuote()
        {
            int quote = areaPrice();
            quote += drawerPrice();
            quote += surfaceMaterialPrice();
            quote += rushPrice();
            return quote;
        }
        private int drawerPrice()
        {
            return this.desk.numberOfDrawers * 50;
        }

        private int areaPrice()
        {
            if (this.desk.surfaceArea > 1000)
            {
                return this.desk.surfaceArea;
            }
            else
            {
                return 0;
            }
        }

        private int surfaceMaterialPrice()
        {
            DesktopMaterial material = this.desk.surfaceMaterial;
            switch (material)
            {
                case DesktopMaterial.oak:
                    return 200;
                case DesktopMaterial.laminate:
                    return 100;
                case DesktopMaterial.pine:
                    return 50;
                case DesktopMaterial.rosewood:
                    return 300;
                case DesktopMaterial.veneer:
                    return 125;
                default:
                    return 0;
            }
        }

        private int rushPrice()
        {
            switch (this.rushOrder)
            {
                case RushOrderType.threeDay:
                    int price = 60;
                    if (this.desk.surfaceArea > 2000)
                    {
                        price = 80;
                    }
                    else if (this.desk.surfaceArea > 1000)
                    {
                        price = 70;
                    }
                    return price;


                case RushOrderType.fiveDay:
                    price = 40;
                    if (this.desk.surfaceArea > 2000)
                    {
                        price = 60;
                    }
                    else if (this.desk.surfaceArea > 1000)
                    {
                        price = 50;
                    }
                    return price;


                case RushOrderType.sevenDay:
                    price = 30;
                    if (this.desk.surfaceArea > 2000)
                    {
                        price = 40;
                    }
                    else if (this.desk.surfaceArea > 1000)
                    {
                        price = 35;
                    }
                    return price;

                default:
                    return 0;
            }
        }
    }
    public enum RushOrderType
    {
        none,
        threeDay,
        fiveDay,
        sevenDay
    }
}
