using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using LiveSplit.Options;
using LiveSplit.Web.SRL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.UI.Components
{
    public class MoreComparisonsGenerator : IComparisonGenerator
    {
        private int method;
        public List<Time> segmentTimes = new List<Time>();

        public IRun Run { get; set; }
        public String Name { get; set; }
        public Time FinalTime { get; set; }
        public int NumericPercent { get; set; }

        public MoreComparisonsGenerator(IRun run, string name, int method, Time finalTime, int randPercent)
        {
            Run = run;
            Name = name;
            this.method = method;
            FinalTime = finalTime;
            NumericPercent = randPercent;

        }
        public void Generate(ISettings settings)
        {
            if (!FinalTime.RealTime.HasValue)
                FinalTime = Run[Run.Count - 1].PersonalBestSplitTime;


            Run.CustomComparisons.Add(Name);
            generateSegmentList(Run, method);

            int index = 0;
            foreach(ISegment segment in Run)
            {
                segment.Comparisons[Name] = segmentTimes[index];
                index++;
            }
        }

        private void generateSegmentList(IRun run, int method)
        {
            if (method == 0)
                constantTimeSave(run);
            if (method == 1)
                lengthBasedSplits(run);
            if (method == 2)
                randomTimeSave(run);
            if (method == 3)
                averageSplits(run);
        }

        //TODO: Implement this (when i feel like it)
        private void averageSplits(IRun run)
        {

        }

        private void constantTimeSave(IRun run)
        {
            long timeSavePerSplitInTicks = (FinalTime - getSOB(run)).RealTime.Value.Ticks / run.Count;
            long runningTime = 0L;

            if (timeSavePerSplitInTicks < 0)
                timeSavePerSplitInTicks = 0;

            foreach(ISegment segment in run)
            {
                if (segment.BestSegmentTime.RealTime.HasValue)
                {
                    runningTime += segment.BestSegmentTime.RealTime.Value.Ticks + timeSavePerSplitInTicks;
                    segmentTimes.Add(new Time(TimeSpan.FromTicks(runningTime)));
                }
                else
                {
                    runningTime += timeSavePerSplitInTicks;
                    segmentTimes.Add(new Time(null, null));
                }
            }
        }

        private void lengthBasedSplits(IRun run)
        {
            long totalSOBInTicks = getSOB(run).RealTime.Value.Ticks;
            long totalTimeSaveInTicks = (FinalTime - getSOB(run)).RealTime.Value.Ticks;
            long runningTime = 0L;

            if (totalTimeSaveInTicks < 0)
                totalTimeSaveInTicks = 0;

            foreach(ISegment segment in run)
            {
                if (segment.BestSegmentTime.RealTime.HasValue)
                {
                    double portionOfRun = segment.BestSegmentTime.RealTime.Value.Ticks * 1.0 / totalSOBInTicks;
                    runningTime += (long)(segment.BestSegmentTime.RealTime.Value.Ticks + (portionOfRun * totalTimeSaveInTicks));
                    segmentTimes.Add(new Time(TimeSpan.FromTicks(runningTime)));
                }
                else
                {
                    segmentTimes.Add(new Time(null, null));
                }
            }
        }

        private void randomTimeSave(IRun run)
        {
            double[] percentages = new double[run.Count];
            double runningSum = 0;

            long totalTimeSaveInTicks = (FinalTime - getSOB(run)).RealTime.Value.Ticks;
            long runningTime = 0L;

            Random rand = new Random();

            for (int i = 0; i < run.Count; i++)
            {
                percentages[i] = rand.NextDouble() - (NumericPercent/200.0);
                runningSum += percentages[i];
            }

            for (int i = 0; i < percentages.Length; i++)
            {
                percentages[i] *= 1.0 / runningSum;
            }

            int index = 0;
            foreach (ISegment segment in run)
            {
                if(segment.BestSegmentTime.RealTime.HasValue)
                {
                    runningTime += segment.BestSegmentTime.RealTime.Value.Ticks + (long)(percentages[index] * totalTimeSaveInTicks);
                    segmentTimes.Add(new Time(TimeSpan.FromTicks(runningTime)));
                }
                else
                {
                    runningTime += (long)(percentages[index] * totalTimeSaveInTicks);
                    segmentTimes.Add(new Time(null, null));
                }

                index++;

            }
        }

        public static Time getSOB(IRun run)
        {
            Time sumOfBest = Time.Zero;

            foreach(ISegment segment in run)
            {
                if (segment.BestSegmentTime.RealTime.HasValue)
                    sumOfBest += segment.BestSegmentTime;
                else
                    sumOfBest += Time.Zero;
            }

            return sumOfBest;

        }
    }
}
