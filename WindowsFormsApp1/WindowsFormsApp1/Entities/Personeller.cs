namespace WindowsFormsApp1.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personeller")]
    public partial class Personeller
    {
        [Key]
        public int PersonelD { get; set; }

        public int? BirimID { get; set; }

        [StringLength(50)]
        public string AdiSoyadi { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [Column(TypeName = "text")]
        public string Adres { get; set; }

        [MaxLength(50)]
        public byte[] Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }

        public bool? IsActive { get; set; }
    }
}
