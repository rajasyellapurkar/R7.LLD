using System;

namespace R7.DesignPattern.PrototypeDesignPattern
{
    public static class PrototypeMain
    {
        public static void Entry()
        {
            INotebookRegistry registry = new NotebookRegistry();

            Notebook a4NoteBook = registry.NoteBookDictionary[NoteBookTypes.A4];

            for(int i=0; i<10; i++)
            {
                Notebook notebook = (Notebook) a4NoteBook.Clone();
                notebook.Cover = $"Cover{i + 1}";
                notebook.Facts = $"Fact{i+1}";

                Console.WriteLine(notebook.Cover);
                Console.WriteLine(notebook.Facts);
            }
        }
    }
}
