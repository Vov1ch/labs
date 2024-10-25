string word = Console.ReadLine();
MyString ob = new MyString();
ob.str = word;
Console.WriteLine(ob.Reverse(word));
Console.WriteLine(ob.UcFirst(word));
Console.WriteLine(ob.UcWords(word));
class MyString
{
    public string str;
    public string Reverse(string s)
    {
        var a = s.ToCharArray();
        Array.Reverse(a);
        string rs = String.Join("", a);
        return rs;     
    }
    public string UcFirst(string s)
    {
        var a = s.ToCharArray();
        a[0] = Char.ToUpper(a[0]);
        String rs = String.Join("", a);
        return rs;
    }
    public string UcWords(string s)
    {
        string[] lsta = s.Split(" ");
        string gg = "";

        for (int i = 0; i < lsta.Length; i++)
        {
            var a = lsta[i].ToCharArray();
            a[0] = Char.ToUpper(a[0]);
            String rs = String.Join("",a);
            gg+= $"{rs} ";
            
        }
        gg=gg.TrimEnd(' ');
        return gg;
        
    }
}