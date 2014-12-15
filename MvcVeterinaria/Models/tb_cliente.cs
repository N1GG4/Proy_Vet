using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace MvcVeterinaria.Models
{
    public class tb_cliente
    {
        [Key]
        public string cod_cli { get; set; }
        public string pass_cli { get; set; }
        public string nom_cli { get; set; }
        public string ape_cli { get; set; }
        public string correo_cli { get; set; }
    }
}