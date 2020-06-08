using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroDeUsuario.Entidades
{
    class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasena { get; set; }

    }
}
