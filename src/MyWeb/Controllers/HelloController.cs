using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers;

[Route("api/hello")]
[ApiController]
public class HelloController: ControllerBase {
	[HttpGet("hi")]
	public ActionResult<string> Hi() => "Hi";
}