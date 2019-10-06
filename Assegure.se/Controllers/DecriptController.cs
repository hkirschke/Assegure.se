using BlowfishCSharp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assegure.se.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DecriptController : BaseCriptController
  {
    // GET api/decript/example
    [HttpGet("{value}")]
    public ActionResult<string> Get(string value)
    {
      CriptoModelObj.ValueDecript = BlowFishWrapper.Decrypt(value);
      CriptoModelObj.ValueOriginal = value;
      CriptoModelObj.ValueEncript = BlowFishWrapper.Encrypt(CriptoModelObj.ValueDecript);
      return JsonConvert.SerializeObject(CriptoModelObj);
    }
  }
}
