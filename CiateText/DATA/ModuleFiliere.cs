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
    
    public partial class ModuleFiliere
    {
        public int IdMF { get; set; }
        public string CodeFiliere { get; set; }
        public int NumeroModule { get; set; }
        public int Annee { get; set; }
        public int MasseHoraire { get; set; }
    
        public virtual Filiere Filiere { get; set; }
        public virtual Module Module { get; set; }
    }
}
