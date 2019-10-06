using Assegure.se.Model;
using Microsoft.AspNetCore.Mvc;

namespace Assegure.se.Controllers
{
  public class BaseCriptController : ControllerBase
  {
    private CriptoModel _criptoModel;

    public CriptoModel CriptoModelObj
    {
      get
      {
        if (_criptoModel is null)
        {
          _criptoModel = new CriptoModel();
          return _criptoModel;
        }
        return _criptoModel;
      }
    }
  }
}