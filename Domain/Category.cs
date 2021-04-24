﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("ProductCategories")]
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

/*        public Category ParentCategory { get; set; }
        [ForeignKey("ParentCategoryId")]
        public Guid ParentCategoryId { get; set; }*/
        
        // Navigation Property
        public List<Product> CategoryProducts { get; set; }
    }
}
