using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorsDZ
{
    class TextArray
    {
    private string[] textArray;

    public TextArray(string[] textArray)
    {
        this.textArray = textArray;
    }

    public string this[int index]
    {
        get { return textArray[index % textArray.Length]; }
        set { textArray[index % textArray.Length] = value; }
    }

    public char this[int index1, int index2]
    {
        get { return textArray[index1 % textArray.Length][index2 % textArray[index1 % textArray.Length].Length]; }
        set { textArray[index1 % textArray.Length] = textArray[index1 % textArray.Length].Substring(0, index2 % textArray[index1 % textArray.Length].Length) + value + textArray[index1 % textArray.Length].Substring(index2 % textArray[index1 % textArray.Length].Length + 1); }
    }
}

}
