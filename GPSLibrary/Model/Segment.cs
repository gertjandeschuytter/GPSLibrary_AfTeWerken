using GPSLibrary.Exceptions;
using System;
using System.Collections.Generic;

namespace GPSLibrary.Model {
    public class Segment {
        public int SegmentID { get; private set; }
        public List<Punt> Punten { get; private set; }
        public Knoop BeginKnoop { get; private set; }
        public Knoop EindKnoop { get; private set; }

        public Segment(int segmentID, List<Punt> punten, Knoop beginKnoop, Knoop eindKnoop) {
            setSegmentID(segmentID);
            Punten = punten;
            setBeginKnoop(beginKnoop);
            setEindKnoop(eindKnoop);
        }
        public void setSegmentID(int segmentId) {
            if (segmentId <= 0) {
                throw new SegmentException($"SegmentId {segmentId} moet groter zijn dan nul!");
            } else {
                SegmentID = segmentId;
            }
        }
        public void setBeginKnoop(Knoop knoop) {
            if (knoop == null) {
                throw new SegmentException("Knoop mag niet null zijn");
            }
            if (knoop == EindKnoop) {
                throw new SegmentException("Beginknoop mag niet hetzelfde zijn als de eindknoop!");
            }
            if (knoop == BeginKnoop) {
                throw new SegmentException("Beginknoop bestaat al!");
            }
            if (Punten != null && Punten[0] != knoop.Punt) {
                throw new SegmentException("punt mag niet nul zijn en het eerste punt van een segment moet gelijk zijn aan het begin van de knoop");
            }
            BeginKnoop = knoop;
        }
        public void setEindKnoop(Knoop knoop) {
            if (knoop == null) {
                throw new SegmentException("Knoop mag niet null zijn");
            }
            if (knoop == BeginKnoop) {
                throw new SegmentException("Eindknoop mag niet hetzelfde zijn als de beginknoop!");
            }
            if (knoop == EindKnoop) {
                throw new SegmentException("Eindknoop bestaat al!");
            }
            if (Punten != null && Punten[Punten.Count - 1] != knoop.Punt) {
                throw new SegmentException("punt mag niet nul zijn en het eerste punt van een segment moet gelijk zijn aan het begin van de knoop");
            }
            BeginKnoop = knoop;
        }
    }
}
