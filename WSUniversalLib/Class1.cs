
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Class1
    {
        int count;
        double width;
        double height;
        double product_type;
        double material_type;
        double kolvo_mater;
        double kolvo_material_without_marriage;

        public Class1(int count, double width,double height, double product_type, double material_type)
        {
            this.count = count;
            this.width = width;
            this.height = height;
            this.product_type = product_type;
            this.material_type = material_type;
        }

        public void MaterialFromMarriage (int count, double width, double height, double product_type, double material_type)
        {
            switch(product_type)
            {
                case 1:
                    kolvo_mater = width * height * count * 1.1;
                    MaterialWithoutMarriage(kolvo_mater, material_type);
                    break;
                case 2:
                    kolvo_mater = width * height * count * 2.5;
                    MaterialWithoutMarriage(kolvo_mater, material_type);
                    break;
                case 3:
                    kolvo_mater = width * height * count * 8.43;
                    MaterialWithoutMarriage(kolvo_mater, material_type);
                    break;
                    default:
                    kolvo_mater = -1;
                    MaterialWithoutMarriage(kolvo_mater, material_type);
                    break;
            }
        }
        public double MaterialWithoutMarriage(double kolvo_mater, double material_type)
        {
            if (material_type == -1)
            {
                return -1;
            }
            else
            {
                switch(material_type)
                {
                    case 1:
                        kolvo_material_without_marriage = kolvo_mater / 100 * 100.3;
                        return kolvo_material_without_marriage;
                        break;
                    case 2:
                        kolvo_material_without_marriage = kolvo_mater / 100 * 100.12;
                        return kolvo_material_without_marriage;
                        break;
                    default:
                        return -1;
                        break;
                }
            }
          
        }
    }
}
