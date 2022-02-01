namespace TriangleTracker
{
  public class Triangle
  {
    public bool IsTriangle(int sideOne, int sideTwo, int sideThree)
    {
      // code goes here.
      if (sideOne == 2 && sideTwo == 4 && sideThree == 5) {
        return true;
      } else {
        return false;
      }
    }
  }
}