using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.DtoLayer.DistrictDto
{
    public class ResultDistrictDto
    {
        public int DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public int? DistrictCity { get; set; }
    }
}
