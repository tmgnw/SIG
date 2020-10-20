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
    public class BarangRepository : GeneralRepository<Barang, Context>
    {
        private readonly Context _myContext;
        IConfiguration _configuration { get; }
        DynamicParameters parameters = new DynamicParameters();
        public BarangRepository(Context myContext, IConfiguration configuration) : base(myContext)
        {
            _configuration = configuration;
            _myContext = myContext;
        }

        public async Task<IEnumerable<BarangVM>> GetAllBarang()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("connection")))
            {
                var spName = "SP_GetBarang";
                var data = await connection.QueryAsync<BarangVM>(spName, commandType: CommandType.StoredProcedure);
                return data;
            }
        }
    }
}