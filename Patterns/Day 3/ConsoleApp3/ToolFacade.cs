namespace ConsoleApp3
{
    public class ToolFacade
    {
        Compiller _compiller;
        TextEditor _textEditor;
        Collector _collector;

        public ToolFacade(Compiller compiller, TextEditor textEditor, Collector collector)
        {
            _compiller = compiller;
            _textEditor = textEditor;
            _collector = collector;
        }

        public void PerformOperations()
        {
            _textEditor.Save();
            _compiller.Validate();
            _compiller.Compile();
            _collector.Collect();
            _collector.CopyOutput();
        }
    }
}
