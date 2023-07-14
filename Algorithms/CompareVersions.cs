using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace Algorithms
{
    //Version numbers are strings that are used to identify unique states of software products.
    //A version number is in the format a.b.c.d.and so on where a, b, etc.are numeric strings separated by dots.
    //These generally represent a hierarchy from major to minor changes. Given two version numbers version1 and version2,
    //conclude which is the latest version number. Your code should do the following:
    //If version1 > version2 return 1.
    //If version1 < version2 return -1.
    //Otherwise return 0.
    public class CompareVersions
    {
        public static string CompareVersion(string version1, string version2)
        {
            
            if (version1[2] != '.' && version2[2] != '.')
            {
                string[] firstVersioning = version1.Split(".");
                string[] secondVersioning = version2.Split(".");
            }
            return "";
        }
    }
}
