using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLibrary;
using DomainModelLibrary;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkpackMVC
{
  [Authorize]
  [Route("api/[controller]")]
  public class UsersDataController : Controller
  {
    private readonly IMapper _mapper;
    private readonly IBLUserRepository _userRepository;
    public UsersDataController(IBLUserRepository userRepository, IMapper mapper)
    {
      _mapper = mapper;
      _userRepository = userRepository;
    }

    // GET: api/values
    [HttpGet]
    public IEnumerable<User> Get()
    {
      var identity = (ClaimsIdentity)User.Identity;
      string CompanyId = identity.FindFirst("CompanyId").Value;
      List<User> lt = _userRepository.GetAllusers(Convert.ToInt32(CompanyId)).ToList();
      return lt;
    }

    //// POST api/values
    [HttpPost]
    public OperationResult Post([FromBody]User user, [FromBody]UserRole[] userRole)
    {
      var identity = (ClaimsIdentity)User.Identity;
      string CompanyId = identity.FindFirst("CompanyId").Value;
      string UserId = identity.FindFirst("UserId").Value;
      return _userRepository.CreateOrEditUser(user, userRole,Convert.ToInt32(CompanyId), Convert.ToInt32(UserId));
    }

    //PUT api/values/5
    [HttpPut]
    public User Put([FromBody]User User)
    {
      try
      {
        User.EntityState = DomainModelLibrary.EntityState.Modified;
        User.FirstName = User.FirstName;
        User.LastName = User.LastName;
        _userRepository.Updateuser(User);
      }
      catch (Exception ex)
      {
        ex.ToString();
      }
      return User;
    }

    //// DELETE api/values/5
    [HttpDelete("{id}")]
    public User Delete(int id)
    {
      User user = null;
      try
      {
        user = _userRepository.GetuserByID(id);
        user.EntityState = DomainModelLibrary.EntityState.Deleted;
        _userRepository.Removeuser(user);
      }
      catch (Exception e)
      {
        // return e.ToString();
      }
      return user;
    }

  }
}
