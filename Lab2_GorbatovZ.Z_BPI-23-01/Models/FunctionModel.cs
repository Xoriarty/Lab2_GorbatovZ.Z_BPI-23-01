namespace Lab2_GorbatovZ.Z_BPI_23_01.Models
{
    public abstract class FunctionModel
    {
        private string _path;
        private double _result;
        
            public FunctionModel(string path)
            {
                Path = path;
            }
            public string Path
            {
                get { return _path; }
                set
                { _path = value; }
            }
            public double Result
            {
                get { return _result; }
                set
                { _result = value; }
            }
    }
}

