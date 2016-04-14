using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Itera.Fagdag.November.ViewModels
{
    public class ManageBooksViewModel
    {
        [Required]
        [Display(Name = "Excel Файл")]
        public HttpPostedFileBase ExcelSchemaBase { get; set; }
    }
}