namespace interface_example
{
  public class Focus : ICar
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
      return Brand.Ford;
    }
  }
}