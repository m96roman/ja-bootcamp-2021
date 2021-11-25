namespace State
{
    class Brain : ISportsman
    {
        private Sportsman _sportsman = null;

        public Brain(Sportsman sportsman) => SetState(sportsman);

        public void SetState(Sportsman state)
        {
            _sportsman = state;
            _sportsman.SetBrain(this);
        }

        public void Relax()
        {
            this._sportsman.Relax();
        }

        public void IncreaseExerciseIntensity()
        {
            this._sportsman.IncreaseExerciseIntensity();
        }
    }
}
