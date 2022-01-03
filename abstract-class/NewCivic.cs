namespace abstract_class
{
  public class NewCivic : Car
  {
    public override Brand WhichBrand()
    {
      return Brand.Honda;
    }

    public override Color StandartColor()
    {
      return Color.Gray;
    }
  }



}