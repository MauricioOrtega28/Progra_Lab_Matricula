using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progra_Lab_Matricula.Models
{
    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("apellidos")]
        public string Apellidos { get; set; }
        
        [Column("nombres")]
        public string Nombres { get; set; }

        [Column("fecha")]
        public string Fecha_Nacimiento { get; set; }

        [Column("genero")]
        public string Genero { get; set; }
        
        [Column("carrera")]
        public string Carrera { get; set; }
        
    }
}