using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Packt.Shared
{
    public class Product
    {

        public int ProductId { get; set; }

        [Required]
        [StringLength(40)]
        public string? ProductName { get; set; }

        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }

        // foreign key relationship
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

    }



}
