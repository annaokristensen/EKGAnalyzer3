using System;
using System.Collections.Generic;
using DTO;

namespace LogicLayer
{
    public class Algoritme
    {
        private double PtakThreshold = 0.12;
        private double RtakThreshold = 0.5;
        private bool belowThresholdPtak = true;
        private bool belowThresholdRtak = true;
        private int PtakCount = 0;
        private int RtakCount = 0;


        public bool Analyze(EKG ekg)
        {
            List<double> EKGSample = ekg.EKGsamples;

            for (int i = 0; i < EKGSample.Count; i++)
            {
                if(EKGSample[i] > PtakThreshold && belowThresholdPtak == true && EKGSample[i] < RtakThreshold)
                {
                    PtakCount++;
                }
                
                if (EKGSample[i] < PtakThreshold)
                {
                    belowThresholdPtak = true;
                }
                else
                {
                    belowThresholdPtak = false;
                }
            }

            double PtakMinute = (PtakCount / ekg.MeasurementPeriod) *60;

            if (PtakMinute > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
