﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Kategori adı boş geçilemez")]
        [StringLength(20,ErrorMessage ="Max 20 karakter min 4 karakter girmelisiniz",MinimumLength =4)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool Status { get; set; }
        public List<Food> Foods { get; set; }
    }
}
