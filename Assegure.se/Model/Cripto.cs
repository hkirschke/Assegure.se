namespace Assegure.se.Model
{
  public class CriptoModel
  {
    private string _valueEncript;
    private string _valueDecript;
    private string _valueOriginal;

    /// <summary>
    /// Return encript value
    /// </summary>
    public string ValueEncript { get => _valueEncript; set => _valueEncript = value; }
    /// <summary>
    /// Return decript value
    /// </summary>
    public string ValueDecript { get => _valueDecript; set => _valueDecript = value; }
    /// <summary>
    /// Return original value received from api call
    /// </summary>
    public string ValueOriginal { get => _valueOriginal; set => _valueOriginal = value; }
  }
}
