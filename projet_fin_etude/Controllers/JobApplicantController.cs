using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projet_fin_etude.Data;
using projet_fin_etude.Data.Repository;
using projet_fin_etude.Models;

namespace projet_fin_etude.Controllers
{
    [Route("api/jobapplicant")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class JobApplicantController : ControllerBase
    {
        private readonly MyAppDbContext _appDbContext;
        private readonly ICommonRepository<JobApplicant> _commonRepository;
        private readonly IMapper _mapper;


        public JobApplicantController(MyAppDbContext appDbContext, ICommonRepository<JobApplicant> commonRepository,IMapper mapper)
        {
            _appDbContext = appDbContext;
            _commonRepository = commonRepository;
            _mapper = mapper;

        }
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<ApiResponse>> Create([FromBody] JobApplicantDTO request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid) { 
            
               return BadRequest(ModelState);
            }
            var JobApplicant = _mapper.Map<JobApplicant>(request);
            var result= await   _commonRepository.CreateAsync(JobApplicant);
            ApiResponse response = new()
            {
                Data = result,Status=true,StatusCode=HttpStatusCode.OK

            };
            return Ok(response);





        }
    }
}
