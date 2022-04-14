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
    }
}