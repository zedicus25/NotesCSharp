using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            //notebook.ReadFromFile();
            notebook.ShowAll();
            //notebook.AddNote();
           // notebook.AddNote();
            //notebook.UpdateNote();
           // notebook.ShowAll();
            //notebook.SaveToFile();
        }
        
        //реализовать метод чтения из файла и вывод по категории, названию и дате через предикаты
    }
}
