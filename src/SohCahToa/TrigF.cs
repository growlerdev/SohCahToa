using System;

namespace SohCahToa
{
    #if NETSTANDARD2_1_OR_GREATER
    
    /// <summary>
    /// Provides methods for solving trigonometry problems related to right triangles.
    /// Includes calculations for sides, angles, and hypotenuse based on given parameters.
    /// </summary>
    public static class TrigF
    {
        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the length of the side adjacent to the primary angle (run) and the primary angle in degrees.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static float Rise_RunPrimaryAngle(float run, float primaryAngle)
        {
            return run * MathF.Tan(ToRadians(primaryAngle));
        }
        public static float a_bAA(float b, float AA) => Rise_RunPrimaryAngle(b, AA);

        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the length of the hypotenuse and the primary angle in degrees.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static float Rise_HypotenusePrimaryAngle(float hypotenuse, float primaryAngle)
        {
            return hypotenuse * MathF.Sin(ToRadians(primaryAngle));
        }
        public static float a_cAA(float c, float AA) => Rise_HypotenusePrimaryAngle(c, AA);

        /// <summary>
        /// Calculates the length of the side opposite to the complimentary angle (rise) given the length of the side adjacent to the complimentary angle (run) and the complimentary angle in degrees.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complimentary angle.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static float Rise_RunComplimentaryAngle(float run, float complimentaryAngle)
        {
            return run / MathF.Tan(ToRadians(complimentaryAngle));
        }
        public static float a_bBB(float b, float BB) => Rise_RunComplimentaryAngle(b, BB);

        /// <summary>
        /// Calculates the length of the side opposite to the complimentary angle (rise) given the length of the hypotenuse and the complimentary angle in degrees.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static float Rise_HypotenuseComplimentaryAngle(float hypotenuse, float complimentaryAngle)
        {
            return hypotenuse * MathF.Cos(ToRadians(complimentaryAngle));
        }
        public static float a_cBB(float c, float BB) => Rise_HypotenuseComplimentaryAngle(c, BB);

        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the length of the side adjacent to the primary angle (run) and the length of the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static float Rise_RunHypotenuse(float run, float hypotenuse)
        {
            return MathF.Sqrt(MathF.Pow(hypotenuse, 2) - MathF.Pow(run, 2));
        }
        public static float a_bc(float b, float c) => Rise_RunHypotenuse(b, c);

        /// <summary>
        /// Calculates the length of the side adjacent to the primary angle (run) given the length of the side opposite to the primary angle (rise) and the primary angle in degrees.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static float Run_RisePrimaryAngle(float rise, float primaryAngle)
        {
            return rise / MathF.Tan(ToRadians(primaryAngle));
        }
        public static float b_aAA(float a, float AA) => Run_RisePrimaryAngle(a, AA);

        /// <summary>
        /// Calculates the length of the side adjacent to the primary angle (run) given the length of the hypotenuse and the primary angle in degrees.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static float Run_HypotenusePrimaryAngle(float hypotenuse, float primaryAngle)
        {
            return hypotenuse * MathF.Cos(ToRadians(primaryAngle));
        }
        public static float b_cAA(float c, float AA) => Run_HypotenusePrimaryAngle(c, AA);

        /// <summary>
        /// Calculates the length of the side adjacent to the complimentary angle (run) given the length of the side opposite to the complimentary angle (rise) and the complimentary angle in degrees.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complimentary angle.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static float Run_RiseComplimentaryAngle(float rise, float complimentaryAngle)
        {
            return rise * MathF.Tan(ToRadians(complimentaryAngle));
        }
        public static float b_aBB(float a, float BB) => Run_RiseComplimentaryAngle(a, BB);

        /// <summary>
        /// Calculates the length of the side adjacent to the complimentary angle (run) given the length of the hypotenuse and the complimentary angle in degrees.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static float Run_HypotenuseComplimentaryAngle(float hypotenuse, float complimentaryAngle)
        {
            return hypotenuse * MathF.Sin(ToRadians(complimentaryAngle));
        }
        public static float b_cBB(float c, float BB) => Run_HypotenuseComplimentaryAngle(c, BB);

        /// <summary>
        /// Calculates the length of the side adjacent to the primary angle (run) given the length of the side opposite to the primary angle (rise) and the length of the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static float Run_RiseHypotenuse(float rise, float hypotenuse)
        {
            return MathF.Sqrt(MathF.Pow(hypotenuse, 2) - MathF.Pow(rise, 2));
        }
        public static float b_ac(float a, float c) => Run_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the length of the hypotenuse given the length of the side opposite to the primary angle (rise) and the primary angle in degrees.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static float Hypotenuse_RisePrimaryAngle(float rise, float primaryAngle)
        {
            return rise / MathF.Sin(ToRadians(primaryAngle));
        }
        public static float c_aAA(float a, float AA) => Hypotenuse_RisePrimaryAngle(a, AA);

        /// <summary>
        /// Calculates the length of the hypotenuse given the length of the side adjacent to the primary angle (run) and the primary angle in degrees.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static float Hypotenuse_RunPrimaryAngle(float run, float primaryAngle)
        {
            return run / MathF.Cos(ToRadians(primaryAngle));
        }
        public static float c_bAA(float b, float AA) => Hypotenuse_RunPrimaryAngle(b, AA);

        /// <summary>
        /// Calculates the length of the hypotenuse given the length of the side opposite to the complimentary angle (rise) and the complimentary angle in degrees.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complimentary angle.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static float Hypotenuse_RiseComplimentaryAngle(float rise, float complimentaryAngle)
        {
            return rise / MathF.Cos(ToRadians(complimentaryAngle));
        }
        public static float c_aBB(float a, float BB) => Hypotenuse_RiseComplimentaryAngle(a, BB);

        /// <summary>
        /// Calculates the length of the hypotenuse given the length of the side adjacent to the complimentary angle (run) and the complimentary angle in degrees.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complimentary angle.</param>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static float Hypotenuse_RunComplimentaryAngle(float run, float complimentaryAngle)
        {
            return run / MathF.Sin(ToRadians(complimentaryAngle));
        }
        public static float c_bBB(float b, float BB) => Hypotenuse_RunComplimentaryAngle(b, BB);

        /// <summary>
        /// Calculates the length of the hypotenuse given the lengths of the other two sides (rise and run).
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static float Hypotenuse_RiseRun(float rise, float run)
        {
            return MathF.Sqrt(MathF.Pow(rise, 2) + MathF.Pow(run, 2));
        }
        public static float c_ab(float a, float b) => Hypotenuse_RiseRun(a, b);

        /// <summary>
        /// Calculates the primary angle in degrees given the complimentary angle in degrees.
        /// </summary>
        /// <param name="complimentaryAngle">The complimentary angle in degrees.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static float PrimaryAngle_ComplimentaryAngle(float complimentaryAngle)
        {
            return 90 - complimentaryAngle;
        }
        public static float AA_BB(float BB) => PrimaryAngle_ComplimentaryAngle(BB);

        /// <summary>
        /// Calculates the primary angle in degrees given the lengths of the opposite side (rise) and the adjacent side (run).
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static float PrimaryAngle_RiseRun(float rise, float run)
        {
            return ToDegrees(MathF.Atan(rise / run));
        }
        public static float AA_ab(float a, float b) => PrimaryAngle_RiseRun(a, b);

        /// <summary>
        /// Calculates the primary angle in degrees given the length of the opposite side (rise) and the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static float PrimaryAngle_RiseHypotenuse(float rise, float hypotenuse)
        {
            return ToDegrees(MathF.Asin(rise / hypotenuse));
        }
        public static float AA_ac(float a, float c) => PrimaryAngle_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the primary angle in degrees given the length of the adjacent side (run) and the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static float PrimaryAngle_RunHypotenuse(float run, float hypotenuse)
        {
            return ToDegrees(MathF.Acos(run / hypotenuse));
        }
        public static float AA_bc(float b, float c) => PrimaryAngle_RunHypotenuse(b, c);

        /// <summary>
        /// Calculates the complimentary angle in degrees given the primary angle in degrees.
        /// </summary>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The complimentary angle in degrees.</returns>
        public static float ComplimentaryAngle_PrimaryAngle(float primaryAngle)
        {
            return 90 - primaryAngle;
        }
        public static float BB_AA(float AA) => ComplimentaryAngle_PrimaryAngle(AA);

        /// <summary>
        /// Calculates the complimentary angle in degrees given the lengths of the opposite side (rise) and the adjacent side (run).
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complimentary angle.</param>
        /// <param name="run">The length of the side adjacent to the complimentary angle.</param>
        /// <returns>The complimentary angle in degrees.</returns>
        public static float ComplimentaryAngle_RiseRun(float rise, float run)
        {
            return ToDegrees(MathF.Atan(run / rise));
        }
        public static float BB_ab(float a, float b) => ComplimentaryAngle_RiseRun(a, b);

        /// <summary>
        /// Calculates the complimentary angle in degrees given the length of the opposite side (rise) and the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complimentary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The complimentary angle in degrees.</returns>
        public static float ComplimentaryAngle_RiseHypotenuse(float rise, float hypotenuse)
        {
            return ToDegrees(MathF.Acos(rise / hypotenuse));
        }
        public static float BB_ac(float a, float c) => ComplimentaryAngle_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the complimentary angle in degrees given the length of the adjacent side (run) and the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complimentary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The complimentary angle in degrees.</returns>
        public static float ComplimentaryAngle_RunHypotenuse(float run, float hypotenuse)
        {
            return ToDegrees(MathF.Asin(run / hypotenuse));
        }
        public static float BB_bc(float b, float c) => ComplimentaryAngle_RunHypotenuse(b, c);

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
        private static float ToRadians(float angle)
        {
            return angle * (MathF.PI / 180);
        }

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The angle in degrees.</returns>
        private static float ToDegrees(float angle)
        {
            return angle * (180 / MathF.PI);
        }
    }
    
    #endif
}