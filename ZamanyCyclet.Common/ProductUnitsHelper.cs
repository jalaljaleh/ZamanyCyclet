using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanyCyclet.Domain;

namespace ZamanyCyclet.Common
{
    public class ProductUnitsHelper
    {

        public static List<ProductUnit> GetProductUnits()
        {
            return new List<ProductUnit>
        {
            
            new ProductUnit { Name = "عدد", Symbol = "pcs", IsDecimal = false },
            new ProductUnit { Name = "دست", Symbol = "set", IsDecimal = false },
            new ProductUnit { Name = "جفت", Symbol = "pair", IsDecimal = false },
            new ProductUnit { Name = "بسته", Symbol = "pack", IsDecimal = false },
            new ProductUnit { Name = "کارتن", Symbol = "carton", IsDecimal = false },
            new ProductUnit { Name = "حلقه", Symbol = "ring", IsDecimal = false },
            new ProductUnit { Name = "شاخه", Symbol = "branch", IsDecimal = false },
            new ProductUnit { Name = "رول", Symbol = "roll", IsDecimal = false },
            new ProductUnit { Name = "بطری", Symbol = "bottle", IsDecimal = false },
            new ProductUnit { Name = "قوطی", Symbol = "can", IsDecimal = false },
            new ProductUnit { Name = "تیوب", Symbol = "tube", IsDecimal = false },

         
            new ProductUnit { Name = "گرم", Symbol = "g", IsDecimal = true },
            new ProductUnit { Name = "کیلوگرم", Symbol = "kg", IsDecimal = true },

        
            new ProductUnit { Name = "میلی لیتر", Symbol = "ml", IsDecimal = true },
            new ProductUnit { Name = "لیتر", Symbol = "L", IsDecimal = true },
            new ProductUnit { Name = "سی سی", Symbol = "cc", IsDecimal = true },
            new ProductUnit { Name = "گالن", Symbol = "gallon", IsDecimal = true },

           
            new ProductUnit { Name = "میلی متر", Symbol = "mm", IsDecimal = true },
            new ProductUnit { Name = "سانتی متر", Symbol = "cm", IsDecimal = true },
            new ProductUnit { Name = "متر", Symbol = "m", IsDecimal = true },

         
            new ProductUnit { Name = "ساعت", Symbol = "hour", IsDecimal = true },
            new ProductUnit { Name = "نفر ساعت", Symbol = "manhour", IsDecimal = true },
            new ProductUnit { Name = "مورد", Symbol = "item", IsDecimal = false },
            new ProductUnit { Name = "سرویس", Symbol = "service", IsDecimal = false },
            new ProductUnit { Name = "تعمیر", Symbol = "repair", IsDecimal = false },
            new ProductUnit { Name = "تعویض", Symbol = "replace", IsDecimal = false },
            new ProductUnit { Name = "عیب یابی", Symbol = "diagnostic", IsDecimal = false }
        };

        }


    }
}
