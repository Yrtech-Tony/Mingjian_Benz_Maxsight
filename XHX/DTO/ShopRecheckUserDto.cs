using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class ShopRecheckUserDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string ShopName { get; set; }
        public string RecheckUserId { get; set; }
        public char StatusType { get; set; }
        public string RecheckUserName { get; set; }
        public DateTime? InDateTime { get; set; }
    }
}
