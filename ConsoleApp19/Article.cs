using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{

        public  class ARTICLE
        {


            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int PK_Article { get; set; }

            public int? FK_Conditionnement { get; set; }

            public int? FK_Famille { get; set; }

            public int? FK_SousFamille { get; set; }

            public int? FK_Modele { get; set; }

            public int? FK_FournisseurPreferentiel { get; set; }
            [StringLength(50)]
            public string ReferenceInterne { get; set; }

            [StringLength(50)]
            public string ReferenceExterne { get; set; }

            [StringLength(50)]
            public int? FK_Societe { get; set; }

            [StringLength(50)]
            public string PointVente { get; set; }

            [StringLength(100)]
            public string Libelle { get; set; }

            public decimal? QteUnite { get; set; }

            public decimal? PoidsBrut { get; set; }

            public decimal? PoidsNet { get; set; }

            public decimal? Longueur { get; set; }

            public decimal? Largeur { get; set; }

            public decimal? Hauteur { get; set; }

            public decimal? Epaisseur { get; set; }

            public decimal? Cubage { get; set; }

            public bool? EstSerialise { get; set; }

            public bool? EstGereEnStock { get; set; }

            public bool? EstGereParLot { get; set; }

            public decimal? PxAchatHT { get; set; }

            public decimal? PxAchatPour { get; set; }

            public int? UniteFacturationAchat { get; set; }

            public int? UniteFacturationVente { get; set; }

            [StringLength(500)]
            public string Commentaires { get; set; }

            public int? Priorite { get; set; }

            public int? Ordre { get; set; }

            [StringLength(50)]
            public string Type { get; set; }

            [StringLength(50)]
            public string Statut { get; set; }

            [StringLength(50)]
            public string UserCreation { get; set; }

            public DateTime? DateCreation { get; set; }

            [StringLength(50)]
            public string UserModification { get; set; }

            public DateTime? DateModification { get; set; }

            public int? OrigineSynchro { get; set; }

            public string CleSynchro { get; set; }

            public int? CompteurSynchro { get; set; }

            public Guid? IdSynchro { get; set; }

            public int? CheckSum { get; set; }

       
    }
}
