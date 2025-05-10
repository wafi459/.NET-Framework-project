using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ListItemDTO :SpListDTO
    {
        public List<SpListDTO> splist { get; set; }
        public ListItemDTO()
        {
            splist = new List<SpListDTO>();
        }
    }
}
