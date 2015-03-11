﻿namespace Point
{
    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + Math.Pow((firstPoint.Z - secondPoint.Z), 2));
        }
    }
}
