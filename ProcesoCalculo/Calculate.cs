using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Calculate
{
    public static string CompleteReference(string reference)
    {
        string part = "";
        if(reference.Length < 6)
            part = reference.PadLeft(6, '0');
        else
            part = reference.Substring(reference.Length - 6, 6);

        int sum = 0;
        int mul = 2;
        for(int i = part.Length - 1; i >= 0; i--, mul++)
        {
            sum += int.Parse(part[i].ToString()) * mul;
        }

        //Digito verificador
        int ver = 7 - (sum % 7);

        return reference + ver.ToString();
    }
}