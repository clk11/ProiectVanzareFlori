//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proiect_vanzare_flori
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Perioada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Perioada()
        {
            this.t_PerioadaInflorire = new HashSet<t_PerioadaInflorire>();
        }
    
        public int ID_Perioada { get; set; }
        public int Luna { get; set; }
        public int Saptamana { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_PerioadaInflorire> t_PerioadaInflorire { get; set; }
    }
}
