namespace ConsoleApp5.Abstracts
{
    public abstract class Captain
    {
        protected Mediator _mediator;

        public Captain(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void Notify(string message);
    }
}
