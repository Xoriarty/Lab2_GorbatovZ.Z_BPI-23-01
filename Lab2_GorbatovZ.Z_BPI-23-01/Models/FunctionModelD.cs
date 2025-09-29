using System;

namespace Lab2_GorbatovZ.Z_BPI_23_01.Models
{
    public class FunctionModelD : FunctionModel
    {
        private double _a;
        private int _d;
        private int[] _c = new int[6] { 0, 1, 2, 3, 4, 5 };
        private int _indexC;
        public FunctionModelD(double a, int d, int indexC) : base("Resource/img4.png")
        {
            A = a;
            IndexC = indexC;
            D = d;
            Result = Calculate();
        }

        public double A
        {
            get { return _a; }
            set
            {
                _a = value;
            }
        }
        public int[] C
        {
            get { return _c; }
        }
        public int D
        {
            get { return _d; }
            set
            {
                _d = value;
            }
        }
        public int IndexC
        {
            get { return _indexC; }
            set
            {
                _indexC = value;
            }
        }

        public double Calculate()
        {
            double Sum = 0;
            for (int i = 0; i <= D; i++) Sum += Math.Pow(C[IndexC] + A, i);
            return Sum;
        }
    }
}
