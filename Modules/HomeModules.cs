using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/result"] = _ => {

        // int weight = (int)(Request.Query["weight"]);
        // int height = (int)(Request.Query["height"]);
        // int width = (int)(Request.Query["width"]);
        // int depth = (int)(Request.Query["depth"]);

        // if (weight>0 && height>0 && width>0 && depth>0) {
          ParcelVariables myParcelVariables = new ParcelVariables (Request.Query["weight"], Request.Query["height"], Request.Query["width"], Request.Query["depth"]);
          return View["result.cshtml", myParcelVariables];
        // } else {
        //   return View["form_failure.cshtml","Invalid Input"];
        // }
      };
    }
  }
}
