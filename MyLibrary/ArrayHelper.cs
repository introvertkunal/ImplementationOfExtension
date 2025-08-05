namespace MyLibrary
{
    public class ArrayHelper
    {

        public int[] Values { get; set; }
        public ArrayHelper(int[] values)
        {
            Values = values;
        }
        public int Length
        {
            get { return Values.Length; }
        }
    }
}
