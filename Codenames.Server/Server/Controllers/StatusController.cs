using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Route("status")]
public class StatusController : ControllerBase
{
    private ILogger<StatusController> _logger;
    public StatusController(ILogger<StatusController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("Status endpoint has been hit by {ip}", 
            GetClientIP());
        return "Healthy";
    }

    private string GetClientIP()
    {
        return HttpContext.Connection.RemoteIpAddress?.ToString();
    }
}