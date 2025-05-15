using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Onboarding_Project_API;

[ApiController]
[Route("api/v1/hello")]
public class HelloController: ControllerBase
{
    
    
    [HttpGet("{name}")]
    public IActionResult Get(string name)
    {
        return Ok($"Hello World, {name}! " + DateTime.UtcNow.ToString("O"));
    }
    
    
}


public class CreateScoreRequest 
{
    public string name { get; set; }
    public int score { get; set; }
}