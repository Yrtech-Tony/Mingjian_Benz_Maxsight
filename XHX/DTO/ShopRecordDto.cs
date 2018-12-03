using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopRecordDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string RecordUrl { get; set; }
        public char StatusType { get; set; }
        public string Password { get; set; }
        public DateTime? InDateTime { get; set; }
    }
}
