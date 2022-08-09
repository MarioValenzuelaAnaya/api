using api.Data;
using api.Entities;
using api.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly Imember _member;


        public MemberController(Imember member)
        {
            _member = member;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Members>>> GetMembers()
        {
            var members = await _member.GetMembersAsync();
            return Ok(members);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Members>> GetMemberById(int id)
        {
            return await _member.GetMemberByIdAsync(id);


        }

        [HttpPost("register")]
        public ActionResult Register(Members member)
        {

            _member.SaveMember(member);
            return Ok(member);



        }
        [HttpPost("Delete")]
        public ActionResult Delete(Members member)
        {

            _member.DeleTeMember(member);
            return Ok(member);





        }
        [HttpPost("Update")]
        public ActionResult Update(Members member)
        {

            _member.Update(member);
            return Ok(member);



        }
    }
    }
