using System;

namespace Lab2_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelA : FunctionModel
    {
        private double _a;
        private int[] _f = new int[6] { 4, 5, 6, 7, 8, 9 };
        private int _index;
        public FunctionModelA(double a, int index) : base("Resource/img1.png")
        {
            A = a;
            Index = index;
            CalculateResult();
        }
        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
                CalculateResult();

            }
        }
        public int[] F => _f;
        public int Index
        {
            get { return _index; }
            set
            {
                _index = value;
                CalculateResult();
            }
        }

        private void CalculateResult()
        {
            Result = Math.Sin(A * _f[Index]);
        }
    }
}
