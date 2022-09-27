using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Business.Model
{
    public class PontoTuristico : IDisposable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
