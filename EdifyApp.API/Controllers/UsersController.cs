using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using EdifyApp.API.Data;
using EdifyApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdifyApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IEdifyRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IEdifyRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();
            var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);
            return Ok(usersToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            var userToReturn = _mapper.Map<UserForIndividualDto>(user);
            return Ok(userToReturn);
        }
    }
}