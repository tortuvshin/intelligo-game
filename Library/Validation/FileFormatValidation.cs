using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itera.Fagdag.November.Validation.Contracts;
using Microsoft.Owin.Security.Provider;

namespace Itera.Fagdag.November.Validation
{
    public class FileFormatValidation : IFileFormatValidation
    {
        public bool IsImageType(string fileName)
        {
            var format = GetFormat(fileName);

            switch (format)
            {
                case "jpg":
                    return true;
                case "png":
                    return true;
                case "jpeg":
                    return true;
                case "gif":
                    return true;
                default:
                    return false;
            }
        }

        public bool IsExcelType(string fileName)
        {
            var format = GetFormat(fileName);

            switch (format)
            {
                case "xls":
                    return true;
                case "xlsx":
                    return true;
                default:
                    return false;
            }
        }

        private static string GetFormat(string fileName)
        {
            try
            {
                var split = fileName.Split('.');
                var format = split[1];
                return format;
            }
            catch (Exception e)
            {
                return string.Empty;
            }
        }
    }
}