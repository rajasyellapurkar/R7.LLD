using System.Collections.Generic;

namespace R7.DesignPattern.PrototypeDesignPattern
{
    public interface INotebookRegistry
    {
        Dictionary<NoteBookTypes, Notebook> NoteBookDictionary { get; }
    }
}
