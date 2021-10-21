namespace DIvanyshyn_8.AssembliesExample
{
    public class ActionResult
    {
        public ActionResult(object result)
        {
            Result = result;
        }

        public object Result { get; init; }

        public override string ToString()
        {
            return $"Action result: {Result}";
        }
    }
}