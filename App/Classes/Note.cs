using System;
using System.Text;

namespace App
{
    public class Note
    {
        public string Header { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        public DateTime DateCreation { get; private set; }
        
        public Note(string header, string category, string text)
        {
            Header = header.ToLower();
            Category = category.ToLower();
            Text = text;
            DateCreation = DateTime.Now;
        }
        
        public Note(string header, string category, string text, DateTime dateTime)
        {
            Header = header.ToLower();
            Category = category.ToLower();
            Text = text;
            DateCreation = dateTime;
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Header:");
            sb.AppendLine(Header);
            sb.AppendLine("Category:");
            sb.AppendLine(Category);
            sb.AppendLine("Creation date:");
            sb.AppendLine(DateCreation.ToString());
            sb.AppendLine(Text);
            return sb.ToString();
        }

        public string ToStringForFile()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Header+":;");
            sb.Append(Category+":;");
            sb.Append(Text+":;");
            sb.AppendLine(DateCreation.ToString()+":;");
            return sb.ToString();
        }
    }
}