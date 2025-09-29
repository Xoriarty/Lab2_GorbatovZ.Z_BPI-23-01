using System;

namespace Lab2_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelB : FunctionModel
    {
        private double _a;
        private double _b;
        private int[] _f = new int[4] { 10, 20, 30, 40 };
        private int _index;
        public FunctionModelB(double a, int index) : base("Resource/img2.png")
        {
            A = a;
            Index = index;
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
            }
        }
        public int[] F
        {
            get { return _f; }
        }
        public double B
        {
            get { return _b; }
            set
            {
                _b = value;
            }
        }
        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
            }
        }

        public double Calculate()
        {
            return Math.Cos(A * _f[Index]) + Math.Sin(B * _f[Index]);
        }
    }
}
