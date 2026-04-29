using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpWebUI.Dtos.GroupCodeDtos
{
    public class UpdateGroupCodeDto
    {
        public string GroupCodeValue { get; set; } = null!;
        public string? GroupName { get; set; }
    }
}
