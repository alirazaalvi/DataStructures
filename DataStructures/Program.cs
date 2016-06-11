using LinkedList;

namespace DataStructures
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(4);
            linkedList.Add(9);

            linkedList.Remove(2);
        }
    }
}