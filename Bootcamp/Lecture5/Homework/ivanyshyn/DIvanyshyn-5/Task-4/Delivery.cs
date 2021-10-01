namespace DIvanyshyn_5.Task_4
{
    public abstract class Delivery<T> where T : Package
    {
        public virtual void DeliverPackage(T package)
        {
            System.Console.WriteLine($"Hi, {package.Recepient}. We have {package.Title} with size = {package.Size} for you.");
        }
    }
}
