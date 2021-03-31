using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] content = File.ReadAllText("Inlet.in.txt", Encoding.Default).Split('\r');

            for (int i = 0; i < content.Length; i++)
            {
                string[] words = content[i].TrimStart('\n').Split(' ');

                content[i] = string.Empty;

                for (int j = 0; j < words.Length; j++)
                {
                    char firstLetter = words[j][0];

                    for (int n = 0; n <= words[j].Length - 1; n++)
                    {
                        if (words[j].Length == 1)
                        {
                            continue;
                        }
                        else if (firstLetter != words[j][n])
                        {
                            content[i] += words[j] + " ";
                            break;
                        }

                        else continue;
                    }
                }

                content[i] = content[i].TrimEnd(' ');
            }

            File.WriteAllLines("Outlet.out.txt", content);
        }
    }
}
