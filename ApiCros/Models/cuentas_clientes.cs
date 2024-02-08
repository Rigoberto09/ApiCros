namespace ApiCros.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cuentas_clientes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_cliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long numero_cuenta { get; set; }

        [StringLength(100)]
        public string tipo_cuenta { get; set; }

        public DateTime? fecha_cambio { get; set; }

        [StringLength(100)]
        public string detalle { get; set; }

        public long? monto_afectado { get; set; }
    }
}
