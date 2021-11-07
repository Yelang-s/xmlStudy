using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlStudy
{
    public class Parameters
    {
        public string SoftWareVersion { get; set; }
        public string HardWareVersion { get; set; }
        public bool HaveMES { get; set; }
        public bool HavePDCA { get; set; }
        public bool IsUploadMES { get; set; }
        public bool IsUploadPDCA { get; set; }
        public string MachineID { get; set; }
        public string LineID { get; set; }
        public string StationID { get; set; }

    }
}
