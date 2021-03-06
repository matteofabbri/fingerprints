/*
 * Created by: Milton García Borroto (milton.garcia@gmail.com),
 *             Miguel Angel Medina Pérez (miguel.medina.perez@gmail.com), and
 *             Andrés Eduardo Gutiérrez Rodríguez (andres@bioplantas.cu)
 * Created: 
 * Comments by: Miguel Angel Medina Pérez (miguel.medina.perez@gmail.com)
 */

using System;

namespace Fingerprints.Computation
{
    public static class Angle
    {
        public static double ComputeAngle(double dX, double dY)
        {
            if (dX > 0 && dY >= 0)
                return Math.Atan(dY / dX);
            if (dX > 0 && dY < 0)
                return Math.Atan(dY / dX) + 2 * Math.PI;
            if (dX < 0)
                return Math.Atan(dY / dX) + Math.PI;
            if (Math.Abs(dX) < double.Epsilon && dY > 0)
                return Math.PI / 2;
            if (Math.Abs(dX) < double.Epsilon && dY < 0)
                return 3 * Math.PI / 2;
            throw new ArgumentOutOfRangeException();
        }


        public static double Difference2Pi(double alpha, double beta)
        {
            if (beta >= alpha)
                return beta - alpha;
            return beta - alpha + 2 * Math.PI;
        }


        public static double DifferencePi(double alpha, double beta)
        {
            var diff = Math.Abs(beta - alpha);
            return Math.Min(diff, 2 * Math.PI - diff);
        }

        public static double ToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}