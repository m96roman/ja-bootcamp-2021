using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Sportsman
    {      
        public State _state = null;

        public Sportsman(State state) 
        {
            this._state = state;              
        }       

        public void IncreaseExerciseIntensity() 
        {
            this._state.IncreaseExerciseIntensity(this);
        }

        public void Relax()
        {
            this._state.Relax(this);
        }
    }
}
