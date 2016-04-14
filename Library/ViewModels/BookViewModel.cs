using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Controllers;

namespace Itera.Fagdag.November.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string LoggedInUserName { get; set; }

        [Required]
        [Display(Name = "Номын нэр")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Зохиолч")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "Агуулга")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ShortDescription
        {
            get
            {
                var shortDesc = Description.Substring(0, Description.Length/2);
                return shortDesc += "...";
            }
        }

        public string CoverImageUrl { get; set; }

        [Required(ErrorMessage = "Зураг оруулна уу.")]
        [Display(Name = "Зураг")]
        public HttpPostedFileBase CoverImageBase { get; set; }

        [Required]
        [Display(Name = "Хуудас")]
        public int Pages { get; set; }

        [Required]
        [Display(Name = "Хэл")]
        public string Language { get; set; }

        [Required]
        [Display(Name = "ISBN-10")]
        public string ISBN10 { get; set; }

        [Required]
        [Display(Name = "ISBN-13")]
        public string ISBN13 { get; set; }

        private string _reservedBy;

        public string ReservedBy
        {
            get
            {
                return _reservedBy != null && (LoggedInUserName != null && LoggedInUserName == _reservedBy) ? "you" : _reservedBy;
            }
            set { _reservedBy = value; }
        }

        public string ReserveButtonText
        {
            get
            {
                if (string.IsNullOrEmpty(ReservedBy))
                {
                    return "Цуглуулах";
                }
                return "Цуглуулсан " + ReservedBy;
            }
        }

        public string ReserveButtonStyle
        {
            get
            {
                if (string.IsNullOrEmpty(ReservedBy))
                {
                    return "btn btn-success";
                }
                return "btn btn-danger disableLink";
            }
        }

        public string ReserveLabelText
        {
            get
            {
                if (string.IsNullOrEmpty(ReservedBy))
                {
                    return "Нээлттэй";
                }
                return "Цуглуулсан " + ReservedBy;
            }
        }

        public string ReserveLabelStyle
        {
            get
            {
                if (string.IsNullOrEmpty(ReservedBy))
                {
                    return "label label-success";
                }
                return "label label-important";
            }
        }
    }
}