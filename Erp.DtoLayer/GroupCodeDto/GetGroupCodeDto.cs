using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.GroupCodeDto
{
    public class GetGroupCodeDto
    {
        public string GroupCodeValue { get; set; } = null!;
        public string? GroupName { get; set; }
    }
}
