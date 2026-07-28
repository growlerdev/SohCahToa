using System;

namespace SohCahToa
{
    public class Triangle
    {
        public double? Rise { get; set; }
        public double? Run { get; set; }
        public double? Hypotenuse { get; set; }
        public double? PrimaryAngle { get; set; }
        public double? ComplementaryAngle { get; set; }

        public static Triangle FromRiseRun(double rise, double run)
        {
            return new Triangle
            {
                Rise = rise,
                Run = run
            };
        }

        public static Triangle FromRiseHypotenuse(double rise, double hypotenuse)
        {
            return new Triangle
            {
                Rise = rise,
                Hypotenuse = hypotenuse
            };
        }

        public static Triangle FromRunHypotenuse(double run, double hypotenuse)
        {
            return new Triangle
            {
                Run = run,
                Hypotenuse = hypotenuse
            };
        }

        public static Triangle FromRisePrimaryAngle(double rise, double primaryAngle)
        {
            return new Triangle
            {
                Rise = rise,
                PrimaryAngle = primaryAngle
            };
        }

        public static Triangle FromRunPrimaryAngle(double run, double primaryAngle)
        {
            return new Triangle
            {
                Run = run,
                PrimaryAngle = primaryAngle
            };
        }

        public static Triangle FromHypotenusePrimaryAngle(double hypotenuse, double primaryAngle)
        {
            return new Triangle
            {
                Hypotenuse = hypotenuse,
                PrimaryAngle = primaryAngle
            };
        }

        /// <summary>
        /// Calculates all missing triangle values based on the currently set values.
        /// At least two values must be set to perform calculations.
        /// </summary>
        public void CalculateAll()
        {
            int knownValues = CountKnownValues();
            
            if (knownValues < 2)
                throw new InvalidOperationException("At least two values must be set to calculate the triangle.");

            // Keep calculating until all values are known or no progress is made
            int previousKnown = 0;
            while (knownValues < 5 && knownValues != previousKnown)
            {
                previousKnown = knownValues;
                
                CalculateFromTwoSides();
                CalculateFromSideAndAngle();
                CalculateFromAngles();
                CalculateFromTwoSidesIncludingHypotenuse();
                
                knownValues = CountKnownValues();
            }
        }

        private void CalculateFromTwoSides()
        {
            // Calculate from Rise and Run
            if (Rise.HasValue && Run.HasValue)
            {
                if (!Hypotenuse.HasValue)
                    Hypotenuse = Trig.Hypotenuse_RiseRun(Rise.Value, Run.Value);
                
                if (!PrimaryAngle.HasValue)
                    PrimaryAngle = Trig.PrimaryAngle_RiseRun(Rise.Value, Run.Value);
                
                if (!ComplementaryAngle.HasValue)
                    ComplementaryAngle = Trig.ComplementaryAngle_RiseRun(Rise.Value, Run.Value);
            }
            
            // Calculate from Rise and Hypotenuse
            if (Rise.HasValue && Hypotenuse.HasValue)
            {
                if (!Run.HasValue)
                    Run = Trig.Run_RiseHypotenuse(Rise.Value, Hypotenuse.Value);
                
                if (!PrimaryAngle.HasValue)
                    PrimaryAngle = Trig.PrimaryAngle_RiseHypotenuse(Rise.Value, Hypotenuse.Value);
                
                if (!ComplementaryAngle.HasValue)
                    ComplementaryAngle = Trig.ComplementaryAngle_RiseHypotenuse(Rise.Value, Hypotenuse.Value);
            }
            
            // Calculate from Run and Hypotenuse
            if (Run.HasValue && Hypotenuse.HasValue)
            {
                if (!Rise.HasValue)
                    Rise = Trig.Rise_RunHypotenuse(Run.Value, Hypotenuse.Value);
                
                if (!PrimaryAngle.HasValue)
                    PrimaryAngle = Trig.PrimaryAngle_RunHypotenuse(Run.Value, Hypotenuse.Value);
                
                if (!ComplementaryAngle.HasValue)
                    ComplementaryAngle = Trig.ComplementaryAngle_RunHypotenuse(Run.Value, Hypotenuse.Value);
            }
        }

        private void CalculateFromSideAndAngle()
        {
            // Calculate from Run and Primary Angle
            if (Run.HasValue && PrimaryAngle.HasValue)
            {
                if (!Rise.HasValue)
                    Rise = Trig.Rise_RunPrimaryAngle(Run.Value, PrimaryAngle.Value);
                
                if (!Hypotenuse.HasValue)
                    Hypotenuse = Trig.Hypotenuse_RunPrimaryAngle(Run.Value, PrimaryAngle.Value);
            }
            
            // Calculate from Rise and Primary Angle
            if (Rise.HasValue && PrimaryAngle.HasValue)
            {
                if (!Run.HasValue)
                    Run = Trig.Run_RisePrimaryAngle(Rise.Value, PrimaryAngle.Value);
                
                if (!Hypotenuse.HasValue)
                    Hypotenuse = Trig.Hypotenuse_RisePrimaryAngle(Rise.Value, PrimaryAngle.Value);
            }
            
            // Calculate from Hypotenuse and Primary Angle
            if (Hypotenuse.HasValue && PrimaryAngle.HasValue)
            {
                if (!Rise.HasValue)
                    Rise = Trig.Rise_HypotenusePrimaryAngle(Hypotenuse.Value, PrimaryAngle.Value);
                
                if (!Run.HasValue)
                    Run = Trig.Run_HypotenusePrimaryAngle(Hypotenuse.Value, PrimaryAngle.Value);
            }
            
            // Calculate from Run and Complementary Angle
            if (Run.HasValue && ComplementaryAngle.HasValue)
            {
                if (!Rise.HasValue)
                    Rise = Trig.Rise_RunComplementaryAngle(Run.Value, ComplementaryAngle.Value);
                
                if (!Hypotenuse.HasValue)
                    Hypotenuse = Trig.Hypotenuse_RunComplementaryAngle(Run.Value, ComplementaryAngle.Value);
            }
            
            // Calculate from Rise and Complementary Angle
            if (Rise.HasValue && ComplementaryAngle.HasValue)
            {
                if (!Run.HasValue)
                    Run = Trig.Run_RiseComplementaryAngle(Rise.Value, ComplementaryAngle.Value);
                
                if (!Hypotenuse.HasValue)
                    Hypotenuse = Trig.Hypotenuse_RiseComplementaryAngle(Rise.Value, ComplementaryAngle.Value);
            }
            
            // Calculate from Hypotenuse and Complementary Angle
            if (Hypotenuse.HasValue && ComplementaryAngle.HasValue)
            {
                if (!Rise.HasValue)
                    Rise = Trig.Rise_HypotenuseComplementaryAngle(Hypotenuse.Value, ComplementaryAngle.Value);
                
                if (!Run.HasValue)
                    Run = Trig.Run_HypotenuseComplementaryAngle(Hypotenuse.Value, ComplementaryAngle.Value);
            }
        }

        private void CalculateFromAngles()
        {
            // Calculate complementary angle from primary angle
            if (PrimaryAngle.HasValue && !ComplementaryAngle.HasValue)
                ComplementaryAngle = Trig.ComplementaryAngle_PrimaryAngle(PrimaryAngle.Value);
            
            // Calculate primary angle from complementary angle
            if (ComplementaryAngle.HasValue && !PrimaryAngle.HasValue)
                PrimaryAngle = Trig.PrimaryAngle_ComplementaryAngle(ComplementaryAngle.Value);
        }

        private void CalculateFromTwoSidesIncludingHypotenuse()
        {
            // This method handles cases where we might have calculated new values
            // and need to fill in remaining gaps
            if (Rise.HasValue && Run.HasValue && !Hypotenuse.HasValue)
                Hypotenuse = Trig.Hypotenuse_RiseRun(Rise.Value, Run.Value);
        }

        private int CountKnownValues()
        {
            int count = 0;
            if (Rise.HasValue) count++;
            if (Run.HasValue) count++;
            if (Hypotenuse.HasValue) count++;
            if (PrimaryAngle.HasValue) count++;
            if (ComplementaryAngle.HasValue) count++;
            return count;
        }

        /// <summary>
        /// Gets a specific value, calculating it if necessary.
        /// </summary>
        public double GetRise()
        {
            if (!Rise.HasValue) CalculateAll();
            return Rise ?? throw new InvalidOperationException("Unable to calculate Rise with the given values.");
        }

        /// <summary>
        /// Gets a specific value, calculating it if necessary.
        /// </summary>
        public double GetRun()
        {
            if (!Run.HasValue) CalculateAll();
            return Run ?? throw new InvalidOperationException("Unable to calculate Run with the given values.");
        }

        /// <summary>
        /// Gets a specific value, calculating it if necessary.
        /// </summary>
        public double GetHypotenuse()
        {
            if (!Hypotenuse.HasValue) CalculateAll();
            return Hypotenuse ?? throw new InvalidOperationException("Unable to calculate Hypotenuse with the given values.");
        }

        /// <summary>
        /// Gets a specific value, calculating it if necessary.
        /// </summary>
        public double GetPrimaryAngle()
        {
            if (!PrimaryAngle.HasValue) CalculateAll();
            return PrimaryAngle ?? throw new InvalidOperationException("Unable to calculate PrimaryAngle with the given values.");
        }

        /// <summary>
        /// Gets a specific value, calculating it if necessary.
        /// </summary>
        public double GetComplementaryAngle()
        {
            if (!ComplementaryAngle.HasValue) CalculateAll();
            return ComplementaryAngle ?? throw new InvalidOperationException("Unable to calculate ComplementaryAngle with the given values.");
        }

        public override string ToString()
        {
            return $"Triangle - Rise: {Rise?.ToString("F2") ?? "Unknown"}, " +
                   $"Run: {Run?.ToString("F2") ?? "Unknown"}, " +
                   $"Hypotenuse: {Hypotenuse?.ToString("F2") ?? "Unknown"}, " +
                   $"Primary Angle: {PrimaryAngle?.ToString("F2") ?? "Unknown"}°, " +
                   $"Complementary Angle: {ComplementaryAngle?.ToString("F2") ?? "Unknown"}°";
        }
    }
}