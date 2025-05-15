using Microsoft.AspNetCore.Mvc;

namespace Onboarding_Project_API;

[ApiController]
[Route("api/v1/hello")]
public class HelloController: ControllerBase
{
    [HttpGet("{name}")]
    public IActionResult Get(string name)
    {
        return Ok($"Hello World, {name}!" + DateTime.UtcNow.ToString("O"));
    }
    [HttpPost]
    public IActionResult Post([FromBody]CreateScoreRequest request)
    {
        return Ok($"Hello, {request.Name}!");
    }
}

public class CreateScoreRequest 
{
    public string Name { get; set; }
    public int Score { get; set; }
}