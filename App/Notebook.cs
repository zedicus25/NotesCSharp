using System;
using System.Collections.Generic;
using System.IO;

namespace App
{
    public class Notebook
    {
        private List<Note> _notes;

        public Notebook()
        { 
            _notes = new List<Note>();
            ReadFromFile();
        }

        public void AddNote()
        {
            _notes.Add(CreateNote());
        }
        
        public void DeleteNote()
        {
            ShowAll();
            string str = String.Empty;
            Console.WriteLine("\nEnter index note to delete");
            str = Console.ReadLine();

            if (int.TryParse(str, out int ind) == false)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
                return;
            }

            if (IsHas(ind))
            {
                _notes.RemoveAt(ind-1);
                Console.WriteLine("Successful");
            }
            
        }

        public void UpdateNote()
        {
            ShowAll();
            string str = String.Empty;
            Console.WriteLine("\nEnter index note to update");
            str = Console.ReadLine();

            if (int.TryParse(str, out int ind) == false)
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Press any key to close");
                Console.ReadKey();
                return;
            }

            if (IsHas(ind))
            {
                Console.WriteLine("Press enter if you dont need update it");
                Console.WriteLine("Enter new header");
                string note = Console.ReadLine();
                _notes[ind - 1].Header = note == "" ? _notes[ind - 1].Header : note;
                Console.WriteLine("Enter new category");
                note = Console.ReadLine();
                _notes[ind - 1].Category = note == "" ? _notes[ind - 1].Category : note;
                Console.WriteLine("Enter new note");
                note = Console.ReadLine();
                _notes[ind - 1].Text = note == "" ? _notes[ind - 1].Text : note;
            }
        }

        public List<Note> FindByHeader(string header)
        {
            string hed = header.ToLower();
            List<Note> result = new List<Note>();
            foreach (var item in _notes)
            {
                if(item.Header == hed)
                    result.Add(item);
            }
            return result;
        }
        public List<Note> FindByCategory(string category)
        {
            List<Note> result = new List<Note>();
            foreach (var item in _notes)
            {
                if(item.Header == category)
                    result.Add(item);
            }
            return result;
        }

        public List<Note> FindByDate(DateTime dateTime)
        {
            List<Note> result = new List<Note>();
            foreach (var item in _notes)
            {
                if(item.DateCreation.ToShortDateString() == dateTime.ToShortDateString())
                    result.Add(item);
            }
            return result;
        }

        public void ShowAll()
        {
            Console.WriteLine();
            _notes.ForEach(Console.WriteLine);
        }

        public void SaveToFile()
        {
            if (File.Exists("notes.txt"))
            {
                try
                {
                    foreach (var note in _notes)
                    {
                        File.AppendAllText("notes.txt", note.ToStringForFile());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                foreach (var note in _notes)
                {
                    File.AppendAllText("notes.txt",note.ToStringForFile());
                }
            }
        }

        private void ReadFromFile()
        {
            if(File.Exists("notes.txt") == false)
                return;;
            string str = File.ReadAllText("notes.txt");
            string[] arr = str.Split('\n');
            Array.Resize(ref arr, arr.Length-1);
            foreach (var t in arr)
            {
                string[] elem = t.Split(":;");
                Array.Resize(ref elem, elem.Length-1);
                _notes.Add(new Note(elem[0],elem[1],elem[2], DateTime.Parse(elem[3])));
            }
        }

        private bool IsHas(int ind) => ind > 0 && ind < _notes.Count;

        private Note CreateNote()
        {
            Console.WriteLine();
            string text = String.Empty;
            string category = String.Empty;
            string header = String.Empty;
            Console.WriteLine("Enter header:");
            header = Console.ReadLine();
            Console.WriteLine("Enter category:");
            category = Console.ReadLine();
            Console.WriteLine("Enter note:");
            text = Console.ReadLine();
            return new Note(header, category, text);
        }

        ~Notebook()
        {
            SaveToFile();
        }
    }
}