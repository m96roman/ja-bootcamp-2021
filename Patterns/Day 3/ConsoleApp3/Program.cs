namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Facade */

            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            Collector collector = new Collector();

            ToolFacade toolFacade = new ToolFacade(compiller, textEditor, collector);

            Tool tool = new Tool();
            tool.ToolActions(toolFacade);
        }
    }
}
