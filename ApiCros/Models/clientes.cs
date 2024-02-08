namespace ApiCros.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clientes
    {
        [Key]
        public int id_cliente { get; set; }

        [StringLength(50)]
        public string primer_nombre { get; set; }

        [StringLength(50)]
        public string segundo_nombre { get; set; }

        [StringLength(50)]
        public string primer_apellido { get; set; }

        [StringLength(50)]
        public string segundo_apellido { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(15)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        public DateTime? fecha_registro { get; set; }

        [StringLength(20)]
        public string usuario_creo { get; set; }

        [StringLength(20)]
        public string usuario_borro { get; set; }
    }
}
