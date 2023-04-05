using System;
using System.Collections.Generic;

#nullable disable

namespace tracuu.Models
{
    public partial class Trungtam
    {
        public Trungtam()
        {
            Lichdangkiems = new HashSet<Lichdangkiem>();
        }

        public int MaTt { get; set; }
        public string TenTrungtam { get; set; }
        public string DiaChi { get; set; }
        public string KhuVuc { get; set; }

        public virtual ICollection<Lichdangkiem> Lichdangkiems { get; set; }
    }
}
