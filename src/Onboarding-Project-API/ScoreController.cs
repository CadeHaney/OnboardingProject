using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Onboarding_Project_API;

[ApiController]
[Route("api/v1/score")]
public class ScoreController : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult> Create(Scores scores)
    {
        await _dbContext.Scores.AddAsync(scores);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    private readonly ScoreDbContext _dbContext;
    public ScoreController(ScoreDbContext scoreDbContext)
    {
        _dbContext = scoreDbContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Scores>> GetScores()
    {
        return _dbContext.Scores;
    }

    [HttpGet("{scoreId:int}")]
    public async Task<ActionResult<Scores>> GetScoreById(int scoreId)
    {
        var scores = await _dbContext.Scores.FindAsync(scoreId);
        return scores;
    }
}

