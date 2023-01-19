using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Dias.Resources
{
    internal class DeskQuote
    {
        public Desk desk;
        public string customerName;
        public RushOrderType rushOrder;
        public float quote
        {
            get
            {
                return calculateQuote();
            }
        }
  


        private float calculateQuote()
        {
            float quote = areaPrice();
            quote += drawerPrice();
            quote += surfaceMaterialPrice();
            quote += rushPrice();
            return quote;
        }
        private float drawerPrice()
        {
            return this.desk.numberOfDrawers * 50;
        }

        private float areaPrice()
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
    enum RushOrderType
    {
        none,
        threeDay,
        fiveDay,
        sevenDay
    }
}
