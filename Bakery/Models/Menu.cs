

/*     Business Logic     */ 
namespace Menu
{
  public class Bread
  {
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0) {
        return true;
      } else if (year % 100 == 0) {
        return false; 
      } else {
        return year % 4 == 0;
      }
    }
  }

  public class Pastry
  {
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0) {
        return true;
      } else if (year % 100 == 0) {
        return false; 
      } else {
        return year % 4 == 0;
      }
    }
  }

}
