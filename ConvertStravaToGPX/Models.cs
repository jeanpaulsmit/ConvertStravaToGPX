using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Didago.ConvertStravaToGPX;

public class Coordinates
{
    public decimal[][] latlng { get; set; }
}


public class CoordinatesMetadata
{
    public decimal[] grade_smooth { get; set; }
    public decimal[] distance { get; set; }
    public decimal[] altitude { get; set; }
    public int[] heartrate { get; set; }
    public int[] time { get; set; }
    public int[] watts_calc { get; set; }
}
