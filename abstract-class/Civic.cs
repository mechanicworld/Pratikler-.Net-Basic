
namespace abstract_class
{
  public class Civic : ICar
  {
    public int HowManyWheels()
    {
      return 4;
    }

    public Color StandartColor()
    {
      return Color.Gray;
    }

    public Brand WhichBrand()
    {
      return Brand.Honda;
    }
  }

}