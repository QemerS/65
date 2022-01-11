using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Setting
    {
        public int ID { get; set; }
        [MaxLength(255)]
        public string Logo { get; set; }
        [MaxLength(255)]
        public string UpBannerTitle { get; set; }
        [MaxLength(255)]
        public string LowerBannerTitle { get; set; }

    }
}
