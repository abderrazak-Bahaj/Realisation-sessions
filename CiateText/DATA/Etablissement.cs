//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiateText.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Etablissement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etablissement()
        {
            this.Groupes = new HashSet<Groupe>();
        }
    
        public int IdEtablissement { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public int IdDr { get; set; }
    
        public virtual DirectionRegionale DirectionRegionale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groupe> Groupes { get; set; }
    }
}
