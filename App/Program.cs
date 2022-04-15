using System;
using System.Collections.Generic;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote();
            notebook.AddNote();
            notebook.AddNote();
            
            notebook.ShowAll();
            notebook.UpdateNote();
            notebook.ShowAll();
            notebook.DeleteNote();
            notebook.ShowAll();
            
            List<Note> notes = new List<Note>(notebook.FindByDate(new DateTime(2022,4,15)));
            notes.ForEach(Console.WriteLine);
            notes.Clear();
            notes = notebook.FindByHeader("Today task");
            notes.ForEach(Console.WriteLine);
            notes.Clear();
            notes = notebook.FindByCategory("Lists");
            notes.ForEach(Console.WriteLine);
            notebook.SaveToFile();

        }
    }
}
