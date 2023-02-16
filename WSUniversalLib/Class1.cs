
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
      public static  double  kolvo_mater;
        public static double kolvo_material_without_marriage;

        public Class1(int count, double width,double height, double product_type, double material_type)
        {
            this.count = count;
            this.width = width;
            this.height = height;
            this.product_type = product_type;
            this.material_type = material_type;
        }

        public static double MaterialFromMarriage (int count, double width, double height, double product_type, double material_type)
        {
            switch(product_type)
            {
                case 1:
                    kolvo_mater = width * height * count * 1.1;
                    switch (material_type)
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
                    break;
                case 2:
                    kolvo_mater = width * height * count * 2.5;
                    switch (material_type)
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
                    break;
                case 3:
                    kolvo_mater = width * height * count * 8.43;
                    switch (material_type)
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
                    break;
                    default:
                    return -1;
                    break;
            }
        }
      
        
    }
}
