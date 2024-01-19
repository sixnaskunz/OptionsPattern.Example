namespace OptionsPattern.Example.Controllers;

[Route("[controller]")]
public class OptionsPatternController(IOptions<ExampleOptions> otpOptions,
                           IOptionsSnapshot<ExampleOptions> otpOptionsSnapshot,
                           IOptionsMonitor<ExampleOptions> otpOptionsMonitor
                           ) : ControllerBase
{
    [HttpGet("test")]
    public ContentResult Test()
    {
        return Content("IOptions: " + otpOptions.Value.Title
            + "\r\nIOptionsSnapshot: " + otpOptionsSnapshot.Value.Title
            + "\r\nIOptionsMonitor: " + otpOptionsMonitor.CurrentValue.Title);
    }
}
