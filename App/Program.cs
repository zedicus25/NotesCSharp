using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote();
            notebook.AddNote();
           // notebook.UpdateNote();
            notebook.ShowAll();
            notebook.SaveToFile();
        }
    }
}
