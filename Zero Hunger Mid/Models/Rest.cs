using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zero_Hunger_Mid.Models
{
    public class Rest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }


        //one to many relation
        public virtual ICollection<FoodCollect> FoodCollects { get; set; }
    }
}