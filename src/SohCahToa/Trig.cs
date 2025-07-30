using System;

namespace SohCahToa
{
    /// <summary>
    /// Provides methods for solving trigonometry problems related to right triangles.
    /// Includes calculations for sides, angles, and hypotenuse based on given parameters.
    /// </summary>
    public static class Trig
    {
        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the adjacent side (run) and the primary angle.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static double Rise_RunPrimaryAngle(double run, double primaryAngle)
        {
            return run * Math.Tan(ToRadians(primaryAngle));
        }
        public static double a_bAA(double b, double AA) => Rise_RunPrimaryAngle(b, AA);

        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the hypotenuse and the primary angle.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static double Rise_HypotenusePrimaryAngle(double hypotenuse, double primaryAngle)
        {
            return hypotenuse * Math.Sin(ToRadians(primaryAngle));
        }
        public static double a_cAA(double c, double AA) => Rise_HypotenusePrimaryAngle(c, AA);

        /// <summary>
        /// Calculates the length of the side opposite to the complementary angle (rise) given the adjacent side (run) and the complementary angle.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complementary angle.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static double Rise_RunComplementaryAngle(double run, double complementaryAngle)
        {
            return run / Math.Tan(ToRadians(complementaryAngle));
        }
        public static double a_bBB(double b, double BB) => Rise_RunComplementaryAngle(b, BB);

        /// <summary>
        /// Calculates the length of the side opposite to the complementary angle (rise) given the hypotenuse and the complementary angle.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static double Rise_HypotenuseComplementaryAngle(double hypotenuse, double complementaryAngle)
        {
            return hypotenuse * Math.Cos(ToRadians(complementaryAngle));
        }
        public static double a_cBB(double c, double BB) => Rise_HypotenuseComplementaryAngle(c, BB);

        /// <summary>
        /// Calculates the length of the side opposite to the primary angle (rise) given the adjacent side (run) and the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The length of the opposite side (rise).</returns>
        public static double Rise_RunHypotenuse(double run, double hypotenuse)
        {
            return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(run, 2));
        }
        public static double a_bc(double b, double c) => Rise_RunHypotenuse(b, c);

        /// <summary>
        /// Calculates the length of the adjacent side (run) given the opposite side (rise) and the primary angle.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static double Run_RisePrimaryAngle(double rise, double primaryAngle)
        {
            return rise / Math.Tan(ToRadians(primaryAngle));
        }
        public static double b_aAA(double a, double AA) => Run_RisePrimaryAngle(a, AA);

        /// <summary>
        /// Calculates the length of the adjacent side (run) given the hypotenuse and the primary angle.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static double Run_HypotenusePrimaryAngle(double hypotenuse, double primaryAngle)
        {
            return hypotenuse * Math.Cos(ToRadians(primaryAngle));
        }
        public static double b_cAA(double c, double AA) => Run_HypotenusePrimaryAngle(c, AA);

        /// <summary>
        /// Calculates the length of the adjacent side (run) given the opposite side (rise) and the complementary angle.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complementary angle.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static double Run_RiseComplementaryAngle(double rise, double complementaryAngle)
        {
            return rise * Math.Tan(ToRadians(complementaryAngle));
        }
        public static double b_aBB(double a, double BB) => Run_RiseComplementaryAngle(a, BB);

        /// <summary>
        /// Calculates the length of the adjacent side (run) given the hypotenuse and the complementary angle.
        /// </summary>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static double Run_HypotenuseComplementaryAngle(double hypotenuse, double complementaryAngle)
        {
            return hypotenuse * Math.Sin(ToRadians(complementaryAngle));
        }
        public static double b_cBB(double c, double BB) => Run_HypotenuseComplementaryAngle(c, BB);

        /// <summary>
        /// Calculates the length of the adjacent side (run) given the opposite side (rise) and the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The length of the adjacent side (run).</returns>
        public static double Run_RiseHypotenuse(double rise, double hypotenuse)
        {
            return Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(rise, 2));
        }
        public static double b_ac(double a, double c) => Run_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the length of the hypotenuse given the opposite side (rise) and the primary angle.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double Hypotenuse_RisePrimaryAngle(double rise, double primaryAngle)
        {
            return rise / Math.Sin(ToRadians(primaryAngle));
        }
        public static double c_aAA(double a, double AA) => Hypotenuse_RisePrimaryAngle(a, AA);

        /// <summary>
        /// Calculates the length of the hypotenuse given the adjacent side (run) and the primary angle.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double Hypotenuse_RunPrimaryAngle(double run, double primaryAngle)
        {
            return run / Math.Cos(ToRadians(primaryAngle));
        }
        public static double c_bAA(double b, double AA) => Hypotenuse_RunPrimaryAngle(b, AA);

        /// <summary>
        /// Calculates the length of the hypotenuse given the opposite side (rise) and the complementary angle.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complementary angle.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double Hypotenuse_RiseComplementaryAngle(double rise, double complementaryAngle)
        {
            return rise / Math.Cos(ToRadians(complementaryAngle));
        }
        public static double c_aBB(double a, double BB) => Hypotenuse_RiseComplementaryAngle(a, BB);

        /// <summary>
        /// Calculates the length of the hypotenuse given the adjacent side (run) and the complementary angle.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complementary angle.</param>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double Hypotenuse_RunComplementaryAngle(double run, double complementaryAngle)
        {
            return run / Math.Sin(ToRadians(complementaryAngle));
        }
        public static double c_bBB(double b, double BB) => Hypotenuse_RunComplementaryAngle(b, BB);

        /// <summary>
        /// Calculates the length of the hypotenuse given the lengths of the other two sides.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double Hypotenuse_RiseRun(double rise, double run)
        {
            return Math.Sqrt(Math.Pow(rise, 2) + Math.Pow(run, 2));
        }
        public static double c_ab(double a, double b) => Hypotenuse_RiseRun(a, b);

        /// <summary>
        /// Calculates the primary angle given the complementary angle.
        /// </summary>
        /// <param name="complementaryAngle">The complementary angle in degrees.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static double PrimaryAngle_ComplementaryAngle(double complementaryAngle)
        {
            return 90 - complementaryAngle;
        }
        public static double AA_BB(double BB) => PrimaryAngle_ComplementaryAngle(BB);

        /// <summary>
        /// Calculates the primary angle given the lengths of the opposite side (rise) and the adjacent side (run).
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static double PrimaryAngle_RiseRun(double rise, double run)
        {
            return ToDegrees(Math.Atan(rise / run));
        }
        public static double AA_ab(double a, double b) => PrimaryAngle_RiseRun(a, b);

        /// <summary>
        /// Calculates the primary angle given the length of the opposite side (rise) and the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static double PrimaryAngle_RiseHypotenuse(double rise, double hypotenuse)
        {
            return ToDegrees(Math.Asin(rise / hypotenuse));
        }
        public static double AA_ac(double a, double c) => PrimaryAngle_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the primary angle given the length of the adjacent side (run) and the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the primary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The primary angle in degrees.</returns>
        public static double PrimaryAngle_RunHypotenuse(double run, double hypotenuse)
        {
            return ToDegrees(Math.Acos(run / hypotenuse));
        }
        public static double AA_bc(double b, double c) => PrimaryAngle_RunHypotenuse(b, c);

        /// <summary>
        /// Calculates the complementary angle given the primary angle.
        /// </summary>
        /// <param name="primaryAngle">The primary angle in degrees.</param>
        /// <returns>The complementary angle in degrees.</returns>
        public static double ComplementaryAngle_PrimaryAngle(double primaryAngle)
        {
            return 90 - primaryAngle;
        }
        public static double BB_AA(double AA) => ComplementaryAngle_PrimaryAngle(AA);

        /// <summary>
        /// Calculates the complementary angle given the lengths of the opposite side (rise) and the adjacent side (run).
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complementary angle.</param>
        /// <param name="run">The length of the side adjacent to the complementary angle.</param>
        /// <returns>The complementary angle in degrees.</returns>
        public static double ComplementaryAngle_RiseRun(double rise, double run)
        {
            return ToDegrees(Math.Atan(run / rise));
        }
        public static double BB_ab(double a, double b) => ComplementaryAngle_RiseRun(a, b);

        /// <summary>
        /// Calculates the complementary angle given the length of the opposite side (rise) and the hypotenuse.
        /// </summary>
        /// <param name="rise">The length of the side opposite to the complementary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The complementary angle in degrees.</returns>
        public static double ComplementaryAngle_RiseHypotenuse(double rise, double hypotenuse)
        {
            return ToDegrees(Math.Acos(rise / hypotenuse));
        }
        public static double BB_ac(double a, double c) => ComplementaryAngle_RiseHypotenuse(a, c);

        /// <summary>
        /// Calculates the complementary angle given the length of the adjacent side (run) and the hypotenuse.
        /// </summary>
        /// <param name="run">The length of the side adjacent to the complementary angle.</param>
        /// <param name="hypotenuse">The length of the hypotenuse.</param>
        /// <returns>The complementary angle in degrees.</returns>
        public static double ComplementaryAngle_RunHypotenuse(double run, double hypotenuse)
        {
            return ToDegrees(Math.Asin(run / hypotenuse));
        }
        public static double BB_bc(double b, double c) => ComplementaryAngle_RunHypotenuse(b, c);

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
        private static double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The angle in degrees.</returns>
        private static double ToDegrees(double angle)
        {
            return angle * (180 / Math.PI);
        }
    }
}