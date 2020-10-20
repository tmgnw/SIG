using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Base;
using API.Model;
using API.Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class JenisBarangController : BaseController<JenisBarang, JenisBarangRepository>
    {
        private readonly JenisBarangRepository _repository;
        public JenisBarangController(JenisBarangRepository JenisBarangRepository) : base(JenisBarangRepository)
        {
            this._repository = JenisBarangRepository;
        }
    }
}