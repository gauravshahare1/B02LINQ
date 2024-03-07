public class StudentHelper : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        // return x.Name.CompareTo(y.Name);
        return y.Name.CompareTo(x.Name);
    }
}