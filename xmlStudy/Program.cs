using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters parameters = new Parameters()
            {
                SoftWareVersion = "V1.1.0",
                HardWareVersion = "V1.0.0",
                HaveMES = true,
                HavePDCA = true,
                IsUploadMES = false,
                IsUploadPDCA = false,
                LineID = "L1",
                StationID = "S1",
                MachineID = "M1"
            };
            WRXml.WriteXml(parameters);
            Parameters parameters1 = new Parameters();
            WRXml.ReadXml(out parameters1);
        }
    }
}
