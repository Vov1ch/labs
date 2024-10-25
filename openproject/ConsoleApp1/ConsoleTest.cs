static void Main()
{
    var tree1 = new Tree("сосна", -6);
    var tree2 = new Tree("береза", 80);
}


public class Tree
{
    public Tree(string v1, int v2)
    {
        kind = v1;
        heigt = v2;
    }

    public string kind { get; set; }
    public int heigt { get; set; }

}
