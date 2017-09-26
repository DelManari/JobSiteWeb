using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOfersWebSite.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Job Categorie")]
        public string CategorieName { get; set; }
        [Required]
        [Display(Name = "Categorie Discription")]
        public string CategorieDiscription { get; set; }
        public virtual ICollection<job> Jobs { get; set; }
    }
}