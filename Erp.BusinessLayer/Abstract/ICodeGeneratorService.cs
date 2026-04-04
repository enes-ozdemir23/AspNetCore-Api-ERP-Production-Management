using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.BusinessLayer.Abstract
{
    public interface ICodeGeneratorService
    {
        string GenerateSequential(string lastCode, string prefix, int totalLength);

        string GenerateGroupCode(string lastCode);

        string GenerateCustomerCode(string lastCode, string fixedPart);


    }
}
