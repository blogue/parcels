namespace Parcel.Objects
{
  public class ParcelVariables
  {
    private int _weight;
    private int _height;
    private int _width;
    private int _depth;

    public ParcelVariables(int weight, int height, int width, int depth)
    {
      _weight = weight;
      _height = height;
      _width = width;
      _depth = depth;
    }
    public int Volume()
    {
      return _height * _width * _depth;
    }

    public int Cost()
    {
      return _weight * Volume() / 200;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public int GetHeight()
    {
      return _height;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int GetDepth()
    {
      return _depth;
    }

    public void SetWeight(int weight)
    {
       _weight = weight;
    }

    public void SetHeight(int height)
    {
       _height = height;
    }

    public void SetWidth(int width)
    {
       _width = width;
    }

    public void SetDepth(int depth)
    {
       _depth = depth;
    }

  }
}
