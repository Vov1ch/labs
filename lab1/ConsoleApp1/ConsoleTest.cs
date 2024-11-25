using System.Xml.Linq;

static void Main()
{
    var tree1 = new Tree("сосна", -6);
    var tree2 = new Tree("береза", 80);
    Console.WriteLine(tree1.heigt);


}
Main();




public class Tree
{
    private string Kind;
    private int Heigt;

    public Tree(string v1, int v2)
    {
        kind = v1;
        heigt = v2;
    }

    public string kind
    {
        get { return Kind; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                Kind = value;
        }
    }
    public int heigt
    {
        get { return Heigt; }
        set
        {
            if (value < 0)
            {
                Heigt = 1;
            }
            else
            {
                Heigt = value;
            }
        }
    }

}


