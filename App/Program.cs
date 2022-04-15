using System;
using System.Collections.Generic;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            //notebook.ReadFromFile();
            //notebook.ShowAll();
            //notebook.AddNote();
            //notebook.AddNote();
            //notebook.UpdateNote();
            //notebook.ShowAll();
            //notebook.SaveToFile();
            List<Note> notes = new List<Note>(notebook.FindByDate(new DateTime(2022,4,15)));
            notes.ForEach(Console.WriteLine);
            //notebook.FindByHeader("HeaDer1");
        }
    }
}
