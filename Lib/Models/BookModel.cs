using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lib.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string LoggedInUserName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ShortDescription
        {
            get
            {
                var shortDesc = Description.Substring(0, Description.Length / 2);
                return shortDesc += "...";
            }
        }

        public string CoverImageUrl { get; set; }

        [Required(ErrorMessage = "Please upload a cover image.")]
        [Display(Name = "Cover")]
        public HttpPostedFileBase CoverImageBase { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
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
                    return "Reserve";
                }
                return "Reserved by " + ReservedBy;
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
                    return "Available";
                }
                return "Reserved by " + ReservedBy;
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