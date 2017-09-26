using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace JobOfersWebSite.Models
{
    public class job
    {
        public int Id { get; set; }
        [DisplayName("Job Name")]
        public string JobTitle { get; set; }
        [DisplayName("Job Discription")]
        public string JobDiscription { get; set; }
        [DisplayName("Job Image")]
        public string JobImage { get; set; }

        [DisplayName("Job Categorie")]
        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }
    }
}