namespace Lab2_GorbatovZ.Z_BPI_23_01.Models
{
    public abstract class FunctionModel
    {
        private string _path;
        
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
    }
}

