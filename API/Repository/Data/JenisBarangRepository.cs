using API.Model;
using API.MyContext;
using API.ViewModel;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Data
{
    public class JenisBarangRepository : GeneralRepository<JenisBarang, Context>
    {
        
        public JenisBarangRepository(Context myContext) : base(myContext)
        {

        }
    }
}