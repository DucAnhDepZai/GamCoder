
using System.Collections.Generic;

public class BaseScript
{
    private static Dictionary<string, string> FS;
    private static Dictionary<string, string> ES;

    public static Dictionary<string,string> GetFS()
    {
        if (FS == null)
        {
            FS = new Dictionary<string, string>();
            FS.Add("A_Level1", "");
            FS.Add("A_Level2", "");
            FS.Add("A_Level3", "\n#include <iostream>\r\nusing namespace std;\r\nint main() {\r");
            FS.Add("A_Level4", "\n#include <iostream>\r\nusing namespace std;\r\nint main() {\r");
            FS.Add("A_Level9", "\n#include <iostream>\r\nusing namespace std;\r\nint main() { int LogHeight[10];\r");
            
            return FS;
        }
        else { return FS; }
    }
    public static Dictionary<string, string> GetES()
    {
        if (ES == null)
        {
            ES = new Dictionary<string, string>();
            ES.Add("A_Level1", "");
            ES.Add("A_Level2", "");
            ES.Add("A_Level3", "cout << LogLength;\n}");
            ES.Add("A_Level4", "cout << Log1Height << \" \" << Log2Height << \" \" << Log3Height;\n}");
            ES.Add("A_Level9", "for(int i = 0; i < 10; i++){\n\tcout << LogHeight[i] << \" \";\n}}");
            return ES;
        }
        else { return ES; }
    }
}
