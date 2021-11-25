namespace State
{
    abstract class Sportsman : ISportsman
    {
        protected Brain brain;

        public Sportsman()
        {
        }

        public abstract void IncreaseExerciseIntensity();

        public abstract void Relax();

        internal void SetBrain(Brain brain)
        {
            this.brain = brain;
        }
    }
}
