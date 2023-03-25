using System;
using System.ComponentModel.DataAnnotations;

namespace Zero_Hunger_Mid.Models
{
    public class FoodCollect
    {
        public int id { get; set; }

        [Required]
        public DateTime ExpierdDate { get; set; }
        [Required]

        [Display(Name = "Collection Status")]
        public bool IsCollected { get; set; }


        //foreign key
        public int RestId { get; set; }
        public virtual Rest Rest { get; set; }
    }
}