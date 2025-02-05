//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orm_basefirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vol()
        {
            this.Voyages = new HashSet<Voyage>();
        }
    
        public long Id { get; set; }
        public string AeroportDepart { get; set; }
        public string AeroportArriveePrevue { get; set; }
        public string AeroportArriveeReel { get; set; }
        public System.DateTime DateDepartPrevue { get; set; }
        public System.DateTime DateDepartReel { get; set; }
        public System.DateTime DateArriveePrevue { get; set; }
        public System.DateTime DateArriveeReel { get; set; }
        public string ReferenceLigne { get; set; }
        public string ReferenceVol { get; set; }
        public string Distance { get; set; }
        public Nullable<System.TimeSpan> TempsVolPrevue_heure_ { get; set; }
        public Nullable<System.TimeSpan> TempsVolReel_heure_ { get; set; }
        public int nbEmployee { get; set; }
        public int NbPlaceRestante { get; set; }
        public int NbPlaceRestanteBusiness { get; set; }
        public int NbPlaceRestantePremiere { get; set; }
        public int NbPlaceRestantePremium { get; set; }
        public int NbPlaceRestanteEconomique { get; set; }
        public Nullable<long> idPilote { get; set; }
        public Nullable<long> idCopilote { get; set; }
        public Nullable<long> idHotesse { get; set; }
        public Nullable<bool> Pret { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voyage> Voyages { get; set; }
    }
}
