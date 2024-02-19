namespace R7.DesignPattern.PrototypeDesignPattern
{
    public class Notebook : IClonable
    {
        public int Size { get; set; }
        public int NoOfPages { get; set; }
        public double Price { get; set; }
        public NoteBookTypes Type { get; set; }
        public string Cover { get; set; }
        public string Facts { get; set; }
        public IClonable Clone()
        {
            Notebook notebook = new Notebook();
            notebook.Size = Size;
            notebook.NoOfPages = NoOfPages;
            notebook.Type = Type;
            notebook.Price = Price;
            notebook.Cover = Cover;
            notebook.Facts  = Facts;
            return notebook;
        }
    }

    public enum NoteBookTypes
    {
        A4,
        A5,
        Spiral
    }
}
