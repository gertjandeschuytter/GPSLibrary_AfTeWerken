using System;
using System.Collections.Generic;
using System.Text;

namespace GPSLibrary.Model {
    public class Knoop {

        public int KnoopID { get; set; }
        public Punt Punt { get; set; }

        public Knoop(int knoopID, Punt punt) {
            KnoopID = knoopID;
            Punt = punt;
        }
    }
}
