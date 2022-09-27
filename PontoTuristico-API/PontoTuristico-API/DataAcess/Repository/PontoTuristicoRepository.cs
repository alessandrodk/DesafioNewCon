using Business;
using Business.Interface.IRepository;
using Business.Model;
using DataAcess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PontoTuristicoRepository: Repository<PontoTuristico >, IPontoTuristicoRepository
    {
        public PontoTuristicoRepository(AplicationDbContext db):base(db)
        {
                
        }
    }
}
