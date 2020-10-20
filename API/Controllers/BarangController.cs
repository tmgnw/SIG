using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Base;
using API.Model;
using API.Repository.Data;
using API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class BarangController : BaseController<Barang, BarangRepository>
    {
        private readonly BarangRepository _repository;

        public BarangController(BarangRepository BarangRepository) : base(BarangRepository)
        {
            this._repository = BarangRepository;
        }

        [HttpGet]
        [Route("GetBarang")]
        public async Task<ActionResult<BarangVM>> GetAllBarang()
        {
            var getData = await _repository.GetAllBarang();
            return Ok(new { data = getData });
        }
    }
}