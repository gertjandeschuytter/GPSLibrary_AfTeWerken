using System;
using System.Collections.Generic;
using System.Text;

namespace GPSLibrary.Model {
    public class Punt {
        public double xCoord { get; set; }
        public double yCoord { get; set; }

        public Punt(double xCoord, double yCoord) {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }
    }
}
