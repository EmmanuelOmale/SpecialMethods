using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Given a file path with folder names, '..' (Parent directory), and '.' (Current directory), 
 * return the shortest possible file path (Eliminate all the '..' and '.').

Example
Input: '/Users/Joma/Documents/../Desktop/./../'
Output: '/Users/Joma/'*/

namespace Algorithms
{
    public class FilePath
    {
        public string ShortestFilePath(string filePath)
        {
            string[] directories = filePath.Split('/');
            Stack<string> fileStack = new Stack<string>();
            foreach (var directory in directories)
            {
                if(directory == "..")
                {
                    if (fileStack.Count > 0)
                    {
                        fileStack.Pop();
                    }
                }
                else if (directory == ".")
                {
                    continue;
                }
                else
                {
                    fileStack.Push(directory);
                }
                
            }

            string[] filesResult = fileStack.ToArray();  
            Array.Reverse(filesResult);
            string shotestPath = string.Join("/", filesResult);

            return "/" + shotestPath;
        }
    }
}





