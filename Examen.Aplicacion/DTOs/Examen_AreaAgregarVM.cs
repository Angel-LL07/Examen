﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Aplicacion.DTOs
{
    public class Examen_AreaAgregarVM
    {
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Nombre { get; set; }
    }
}
