namespace TestForUP01.Model
{
    public class ClassModel
    {
        public string ClassName { get; private set; }

        public ClassModel(string className)
        {
            ClassName = className;
        }
    }
}
