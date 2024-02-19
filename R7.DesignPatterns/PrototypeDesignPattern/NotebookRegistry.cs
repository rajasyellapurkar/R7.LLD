using System.Collections.Generic;

namespace R7.DesignPattern.PrototypeDesignPattern
{
    public class NotebookRegistry : INotebookRegistry
    {
        private Dictionary<NoteBookTypes, Notebook> _noteBookDict;
        public NotebookRegistry()
        {
            _noteBookDict = new Dictionary<NoteBookTypes, Notebook>
            {
                { NoteBookTypes.A4, new Notebook() { Cover = "Cover1",Facts = "Fact1", NoOfPages = 100, Price = 250, Size = 4, Type = NoteBookTypes.A4 } },
                { NoteBookTypes.A5, new Notebook() { Cover = "Cover1",Facts = "Fact1", NoOfPages = 85, Price = 350, Size = 5,Type = NoteBookTypes.A5 } }
            };
        }

        public Dictionary<NoteBookTypes, Notebook> NoteBookDictionary => _noteBookDict;
    }
}
