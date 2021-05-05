using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GPSLibrary.Model {
    public class Straat {
        public double Lengte { get; set; }
        public int StraatID { get; set; }
        public string StraatNaam { get; set; }
        public List<Knoop> Knopen { get; set; }
        public List<Segment> Segmenten { get; set; }

        public Straat(int straatID, string straatNaam, List<Segment> segmenten) {
            StraatID = straatID;
            StraatNaam = straatNaam;
            Segmenten = segmenten;
            Knopen = segmenten.Select(e => e.BeginKnoop).Union(segmenten.Select(e => e.EindKnoop)).ToList();
        }
    }
}
