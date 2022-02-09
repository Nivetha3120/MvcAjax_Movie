using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApiUI.Models
{
    public class dataprop
    {
        
            [Key]
            public int movieid { get; set; }
            public string moviename { get; set; }
            public string language { get; set; }
            public string genre { get; set; }
        
    }
}
