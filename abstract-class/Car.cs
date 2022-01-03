namespace abstract_class
{
    public abstract class Car{
      public int HowManyWheels(){
        return 4;
      }

      public virtual Color StandartColor(){
        return Color.White;
      }

      public abstract Brand WhichBrand();
    }
}