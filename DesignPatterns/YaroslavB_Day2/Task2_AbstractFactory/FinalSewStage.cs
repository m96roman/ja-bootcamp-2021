namespace Task2_AbstractFactory
{
    public class FinalSewStage
    {
        private ISleeves _sleeves;
        private IHood _hood;
        private ICollar _collar;
        private IFront _front;
        private IBack _back;

        public FinalSewStage(ISewDepartment department)
        {
            _sleeves = department.CreateSleeves();
            _hood = department.CreateHood();
            _collar = department.CreateCollar();
            _front = department.CreateFront();
            _back = department.CreateBack();
        }

        public string CreateFinalProduct()
        {
            return $"Sewn 'Back' of model - {_back.Model}" +
                $" with 'Front' of model - {_front.Model}" +
                $" with 'Sleeves' of model - {_sleeves.Model}" +
                $" with 'Collar' of model - {_collar.Model}" +
                $" with 'Hood' of model - {_hood.Model}";
        }
    }
}



