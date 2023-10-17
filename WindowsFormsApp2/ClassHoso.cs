using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyhoso
{
    public class hoso
    {
        public string ten { get; set; }
        public string diachi { get; set; }
        public string luong { get; set; }
        public string sdt { get; set; }
        public DateTime datetime { get; set; }
        public hoso(string ten, string luong, string sdt, string diachi, DateTime Time)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.luong = luong;
            this.sdt = sdt;
            this.datetime = Time;
        }
    }
}