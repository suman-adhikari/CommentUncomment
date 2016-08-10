using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Helper
{
   public class Program
    {
      
       static void Main(string[] args)
       {
            Console.WriteLine("Enter the Path");
            string path = Console.ReadLine();
            Console.WriteLine("Enter the command");
            string opt =  Console.ReadLine();
            CommentUncomment(path,opt);
        }

       public static void CommentUncomment(string path, string opt)
       {
           string text = File.ReadAllText(path);
           var start = text.IndexOf("//R", StringComparison.Ordinal);
           var end = text.IndexOf("//RE", StringComparison.Ordinal);
           var subtext = text.Substring(start, end - start);
           string changedText = "";
           bool flag = false;

           List<string> commentList = new List<string>()
            {
                "if (_contentDataRepository.CheckIfContentIsParsedToday",
                "return \"Content Already Exits for the Day\";",
                "return contentDatas.ContentText;",
                "return \"Successfully Parsed Content\";",
                "return error;",
                "return \"Error occured\";",
                "return \"Error occured while logging error\";"
            };

           List<string> unCommentList = new List<string>();
           foreach (var item in commentList)
           {
               unCommentList.Add("//" + item);
           }


           if (opt == "sc")
           {
               changedText = SingleComment(subtext, commentList, unCommentList);
               flag = true;
           }
           else if (opt == "su")
           {
               changedText = SingleUncomment(subtext, unCommentList);
               flag = true;
           }
           else if (opt == "c")
           {
               //string uncommentedSubstring = FnUncomment(path, text, subtext, start, end);
               //FnComment(path, text, uncommentedSubstring, start, end);
           }
           else if (opt == "u")
           {
               //FnUncomment(path, text, subtext, start, end);
           }
           else
           {
               Console.WriteLine("Command Not availabel");
           }
           if (flag)
           {
               text = text.Replace(text.Substring(start, end - start), changedText);
               File.WriteAllText(path, text);
           }
       }


       public static string SingleComment(string subtext, List<string> commentList, List<string> unCommentList)
       {
           string uncommentedSubtext = SingleUncomment(subtext, unCommentList);
           foreach (var item in commentList)
           {
               uncommentedSubtext = uncommentedSubtext.Replace(item, "//" + item);
           }
           return uncommentedSubtext;
       }

       public static string SingleUncomment(string subtext, List<string> commentList)
       {
           foreach (var item in commentList)
           {
               subtext = subtext.Replace(item, item.Replace("//",""));
           }
          return subtext;
       }

       public static string FnUncomment(string path, string text, string subtext, int start, int end)
       {
           const string textToReplace1 = "/*if (_contentDataRepository.CheckIfContentIsParsedToday";
           const string textToReplace2 = "return \"Content Already Exits for the Day\";*/";
           subtext = subtext.Replace(textToReplace1, textToReplace1.Replace("/*", "")).Replace(textToReplace2, textToReplace2.Replace("*/", ""));
           text = text.Replace(text.Substring(start, end - start), subtext);
           File.WriteAllText(path, text);
           return subtext;
       }

       public static void FnComment(string path, string text, string subtext, int start, int end)
       {
           const string replaceText1 = "if (_contentDataRepository.CheckIfContentIsParsedToday";
           const string replaceText2 = "return \"Content Already Exits for the Day\";";
           subtext = subtext.Replace(replaceText1, "/*" + replaceText1).Replace(replaceText2, replaceText2 + "*/");
           text = text.Replace(text.Substring(start, end - start), subtext);
           File.WriteAllText(path, text);
       }

    }
}
