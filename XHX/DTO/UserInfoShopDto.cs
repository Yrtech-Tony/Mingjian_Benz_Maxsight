using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XHX.DTO
{
    public class UserInfoShopDto
    {
        public string ProjectCode { get; set; }
        public string ShopCode { get; set; }
        public string UserId { get; set; }
        public string ShopName { get; set; }
        public string InUserId { get; set; }
        public DateTime? InDateTime { get; set; }

        private char _statusType = StatusTypes.NONE;
        public char StatusType { get { return _statusType; } set { _statusType = value; } }
    }
}
