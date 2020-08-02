using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Models
{
    public class SampleData
    {
        public static void Initialize(MoblieContext context)
        {
            if(!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "Iphone XR",
                        Company = "Apple",
                        Price = 600
                    },
                    new Phone
                    {
                        Name = "Pixel 3",
                        Company = "Google",
                        Price = 500
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxt Edge",
                        Company = "Samsung",
                        Price = 550
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
