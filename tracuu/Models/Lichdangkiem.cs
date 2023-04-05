using System;
using System.Collections.Generic;

#nullable disable

namespace tracuu.Models
{
    public partial class Lichdangkiem
    {
        public int MaLdk { get; set; }
        public DateTime NgayDangkiem { get; set; }
        public DateTime NgayHethan { get; set; }
        public int MaCpt { get; set; }
        public int MaPt { get; set; }
        public int MaTt { get; set; }

        public virtual Chuphuongtien MaCptNavigation { get; set; }
        public virtual Phuongtien MaPtNavigation { get; set; }
        public virtual Trungtam MaTtNavigation { get; set; }
    }
}
