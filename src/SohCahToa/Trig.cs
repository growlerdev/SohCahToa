using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohCahToa
{
    public static class Trig
    {
        //Triangle sides are represented with lower case letters a, b, c
        //a = Short side "rise"
        //b = Long side "depth"
        //c = hypotenuse
        //Triangle angles are represented with two capitol letters AA, BB
        //AA = angle at lines b and c
        //BB = angle at lines a and c

        //All trig functions are expressed as first what you are looking to solve.
        //Example a function named "a_bAA" the first part of the function "a..."
        //Tells us that we are looking to solve for side "a"
        //The last part of the function "..._bAA" tells us that we know side "b" and angle "AA"




        //********************* Solving For Side "a" *******************************
        //**************************************************************************

        public static double Rise_RunPrimaryAngle(double run, double primaryAngle) => a_bAA(run, primaryAngle);
        public static double a_bAA(double b, double AA)
        {
            return b * Math.Tan(AA * (Math.PI / 180));
        }


        public static double Rise_HypotenusePrimaryAngle(double hypotenuse, double primaryAngle) => a_cAA(hypotenuse, primaryAngle);
        public static double a_cAA(double c, double AA)
        {
            return c * Math.Sin(AA * (Math.PI / 180));
        }

        public static double Rise_RunComplimentaryAngle(double run, double complimentaryAngle) => a_bBB(run, complimentaryAngle);
        public static double a_bBB(double b, double BB)
        {
            return b / Math.Tan(BB * (Math.PI / 180));
        }

        public static double Rise_HypotenuseComplimentaryAngle(double hypotenuse, double complimentaryAngle) => a_cBB(hypotenuse, complimentaryAngle);
        public static double a_cBB(double c, double BB)
        {
            return c * Math.Cos(BB * (Math.PI / 180));
        }

        public static double Rise_RunHypotenuse(double run, double hypotenuse) => a_bc(run, hypotenuse);
        public static double a_bc(double b, double c)
        {
            return Math.Sqrt((Math.Pow(c, 2)) - (Math.Pow(b, 2)));
        }

        //********************* Solving For Side "b" *******************************
        //**************************************************************************

        public static double Run_RisePrimaryAngle(double rise, double primaryAngle) => b_aAA(rise, primaryAngle);
        public static double b_aAA(double a, double AA)
        {
            return a / Math.Tan(AA * (Math.PI / 180));
        }

        public static double Run_HypotenusePrimaryAngle(double hypotenuse, double primaryAngle) => b_cAA(hypotenuse, primaryAngle);
        public static double b_cAA(double c, double AA)
        {
            return c * Math.Cos(AA * (Math.PI / 180));
        }

        public static double Run_RiseComplimentaryAngle(double rise, double complimentaryAngle) => b_aBB(rise, complimentaryAngle);
        public static double b_aBB(double a, double BB)
        {
            return a * Math.Tan(BB * (Math.PI / 180));
        }

        public static double Run_HypotenuseComplimentaryAngle(double hypotenuse, double complimentaryAngle) => b_cBB(hypotenuse, complimentaryAngle);
        public static double b_cBB(double c, double BB)
        {
            return c * Math.Sin(BB * (Math.PI / 180));
        }

        public static double Run_RiseHypotenuse(double rise, double hypotenuse) => b_ac(rise, hypotenuse);
        public static double b_ac(double a, double c)
        {
            return Math.Sqrt((Math.Pow(c, 2)) - (Math.Pow(a, 2)));
        }


        //********************* Solving For Side "c" *******************************
        //**************************************************************************

        public static double Hypotenuse_RisePrimaryAngle(double rise, double primaryAngle) => c_aAA(rise, primaryAngle);
        public static double c_aAA(double a, double AA)
        {
            return a / Math.Sin(AA * (Math.PI / 180));
        }

        public static double Hypotenuse_RunPrimaryAngle(double run, double primaryAngle) => c_bAA(run, primaryAngle);
        public static double c_bAA(double b, double AA)
        {
            return b / Math.Cos(AA * (Math.PI / 180));
        }

        public static double Hypotenuse_RiseComplimentaryAngle(double rise, double complimentaryAngle) => c_aBB(rise, complimentaryAngle);
        public static double c_aBB(double a, double BB)
        {
            return a / Math.Cos(BB * (Math.PI / 180));
        }

        public static double Hypotenuse_RunComplimentaryAngle(double run, double complimentaryAngle) => c_bBB(run, complimentaryAngle);
        public static double c_bBB(double b, double BB)
        {
            return b / Math.Sin(BB * (Math.PI / 180));
        }

        public static double Hypotenuse_RiseRun(double rise, double run) => c_ab(rise, run);
        public static double c_ab(double a, double b)
        {
            return Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
        }


        //********************* Solving For Angle "AA" *****************************
        //**************************************************************************

        public static double PrimaryAngle_ComplimentaryAngle(double complimentaryAngle) => AA_BB(complimentaryAngle);
        public static double AA_BB(double BB)
        {
            return 90 - BB;
        }

        public static double PrimaryAngle_RiseRun(double rise, double run) => AA_ab(rise, run);
        public static double AA_ab(double a, double b)
        {
            return Math.Atan((a / b)) * (180 / Math.PI);
        }

        public static double PrimaryAngle_RiseHypotenuse(double rise, double hypotenuse) => AA_ac(rise, hypotenuse);
        public static double AA_ac(double a, double c)
        {
            return Math.Asin((a / c)) * (180 / Math.PI);
        }

        public static double PrimaryAngle_RunHypotenuse(double run, double hypotenuse) => AA_bc(run, hypotenuse);
        public static double AA_bc(double b, double c)
        {
            return Math.Acos((b / c)) * (180 / Math.PI);
        }


        //********************* Solving For Angle "BB" *****************************
        //**************************************************************************

        public static double ComplimentaryAngle_PrimaryAngle(double primaryAngle) => BB_AA(primaryAngle);
        public static double BB_AA(double AA)
        {
            return 90 - AA;
        }

        public static double ComplimentaryAngle_RiseRun(double rise, double run) => BB_ab(rise, run);
        public static double BB_ab(double a, double b)
        {
            return Math.Atan((b / a)) * (180 / Math.PI);
        }

        public static double ComplimentaryAngle_RiseHypotenuse(double rise, double hypotenuse) => BB_ac(rise, hypotenuse);
        public static double BB_ac(double a, double c)
        {
            return Math.Acos((a / c)) * (180 / Math.PI);
        }

        public static double ComplimentaryAngle_RunHypotenuse(double run, double hypotenuse) => BB_bc(run, hypotenuse);
        public static double BB_bc(double b, double c)
        {
            return Math.Asin((b / c)) * (180 / Math.PI);
        }


    }
}

