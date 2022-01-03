namespace abstract_class
{
  public class Corolla : ICar
  {
    public int HowManyWheels()
    {
      return 4;
    }

    public Color StandartColor()
    {
      return Color.White;
    }

    public Brand WhichBrand()
    {
      return Brand.Toyota;
    }
  }

}