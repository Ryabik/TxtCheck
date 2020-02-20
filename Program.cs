using System;
using System.IO;


namespace TextCheck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileInput fileInput = new FileInput();
            StreamReader sr = new StreamReader(fileInput.GetFile());

            string temp = "";

            while (sr.EndOfStream != true)
            {
                temp += sr.ReadLine();
            }
            
            int counter = WordCount.vowelsWord(temp);
           
            Console.WriteLine("Only vowels words count: " + counter);

            sr.Close();
            Console.ReadLine();

        }
    }
}
