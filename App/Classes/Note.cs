using System;
using System.Text;

namespace App
{
    public class Note
    {
        public string Header { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        private DateTime DateCreation { get; set; }
        
        public Note(string header, string category, string text)
        {
            Header = header;
            Category = category;
            Text = text;
            DateCreation = DateTime.Now;
        }

        public Note(string header, string text) : this(header, "Default", text)
        {
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
            sb.Append(DateCreation.ToString()+":;" + "\n");
            return sb.ToString();
        }
    }
}