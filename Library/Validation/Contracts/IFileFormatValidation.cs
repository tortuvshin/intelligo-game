using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itera.Fagdag.November.Validation.Contracts
{
    public interface IFileFormatValidation
    {
        bool IsImageType(string fileName);
        bool IsExcelType(string fileName);
    }
}
