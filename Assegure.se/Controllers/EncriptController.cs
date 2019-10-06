using BlowfishCSharp.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Assegure.se.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EncriptController : BaseCriptController
  {
    // GET api/encript/example
    [HttpGet("{value}")]
    public ActionResult<string> Get(string value)
    {
      CriptoModelObj.ValueOriginal = value;
      CriptoModelObj.ValueEncript = BlowFishWrapper.Encrypt(value);
      CriptoModelObj.ValueDecript = BlowFishWrapper.Decrypt(CriptoModelObj.ValueEncript);
      return JsonConvert.SerializeObject(CriptoModelObj);
    }
  }
}
