//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1_MI
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAMOCHODY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAMOCHODY()
        {
            this.WYPOZYCZENIA = new HashSet<WYPOZYCZENIA>();
        }
    
        public int IDsamochodu { get; set; }
        public string Marka { get; set; }
        public string Typ { get; set; }
        public System.DateTime Rok_produkcji { get; set; }
        public string Kolor { get; set; }
        public double Pojemnosc_silnika { get; set; }
        public int Przebieg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WYPOZYCZENIA> WYPOZYCZENIA { get; set; }
    }
}
