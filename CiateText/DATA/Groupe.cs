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
    
    public partial class Groupe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Groupe()
        {
            this.Affectations = new HashSet<Affectation>();
            this.EmploisTemps = new HashSet<EmploisTemp>();
            this.Stagiaires = new HashSet<Stagiaire>();
        }
    
        public int NumeroGroupe { get; set; }
        public string Nom { get; set; }
        public int Annee { get; set; }
        public int IdTF { get; set; }
        public int IdMF { get; set; }
        public int IdEtablissement { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Affectation> Affectations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmploisTemp> EmploisTemps { get; set; }
        public virtual Etablissement Etablissement { get; set; }
        public virtual ModeFormation ModeFormation { get; set; }
        public virtual TypeFormation TypeFormation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stagiaire> Stagiaires { get; set; }
    }
}
