using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopReportUploadDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public DateTime? UploadDate { get; set; }
        public char StatusType { get; set; }
        public DateTime? UploadDate2 { get; set; }
        public DateTime? InDateTime { get; set; }
    }
}
