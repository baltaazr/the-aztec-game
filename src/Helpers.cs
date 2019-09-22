namespace the_aztec_game
{
  class Helpers
  {
    public static double GetRandomNumber(double minimum = 0, double maximum = 1)
    {
      Random random = new Random();
      return random.NextDouble() * (maximum - minimum) + minimum;
    }
  }
}