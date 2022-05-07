using System;
using System.Collections.Generic;

namespace DTO
{
    public class EKG
    {
        public List<double> EKGsamples { get; set; }
        public double MeasurementPeriod { get; set; }
        public Patient patient { get; set; }

        public EKG(List<double> ekgSamples, double measurementPeriod, Patient patient)
        {
            EKGsamples = ekgSamples;
            MeasurementPeriod = measurementPeriod;
            this.patient = patient;
        }
    }
}
