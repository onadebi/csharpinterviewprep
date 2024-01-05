using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpinterviewprep.LinkeredLists;
public class LinkeeredLiz
{
}
public class MyList
{

    public string Text { get; set; } = null;

    public MyList Next { get; set; } = null;
    public void Add(string text)
    {
        this.Next = new MyList { Text = text };
    }

    ///<summary>
    ///Prints the MyList in reverse order - the last element should be printed first
    ///</summary>
    public void Print()
    {
        Console.WriteLine(this.Text);
        Console.WriteLine(this.Next);
    }
}


