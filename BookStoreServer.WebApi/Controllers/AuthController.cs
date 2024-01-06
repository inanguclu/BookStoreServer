using AutoMapper;
using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserModel = BookStoreServer.WebApi.Models.User;


namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public AuthController(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpPost]
    public IActionResult Register(RegisterDto request)
    {
        //UserModel user = new()
        //{
        //    Email = request.Email,
        //    Lastname = request.Lastname,
        //    Name = request.Name,
        //    Password = request.Password,
        //    Username = request.Username,
        //};

        UserModel user= _mapper.Map<UserModel>(request);        


        _context.Add(user);
        _context.SaveChanges();

        return Ok(new {Message="kayıt işlemi başarıyla tamamlandı"});
       

    }

}
