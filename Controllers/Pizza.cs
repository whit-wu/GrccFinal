using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum CrustType
    {
        HandTossed,
        Pan,
        Thin,
        Cauliflower
    }

    public enum SauceType
    {
        Marinara,
        BBQ,
        Pesto
    }

    public enum CrustFlavor
    {
        Plain,
        GarlicButter,
        Ranch,
        Cajun
    }
    public class Pizza

    {
        [Required]
        public int Id { get; set; }
        [Required]
        public CrustType CrustType { get; set; }
        [Required]
        public SauceType SauceType { get; set; }
        [Required]
        public CrustFlavor CrustFlavor { get; set; }

        public bool? HasExtraCheese { get; set; }
        public bool? HasPepperoni { get; set; }
        public bool? HasOlives { get; set; }
        public bool? HasChicken { get; set; }
        public bool? HasOnions { get; set; }

        public bool? HasPineapple { get; set; }
        [ForeignKey("CustomerOrder")]
        public int UserID { get; set; }






    }
}
