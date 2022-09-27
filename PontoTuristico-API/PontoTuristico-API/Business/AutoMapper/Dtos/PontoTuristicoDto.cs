using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PontoTuristicoDto
    {

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Cidade { get; set; }
        public string Referencia { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }

    }
}
