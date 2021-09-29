namespace DIvanyshyn___Task_3
{
    internal class Task1
    {
        /// <summary>
        /// Design own class hierarchy. Display how it works by calling methods as in examples.
        ///    Requirements:
        ///	- should have abstract and virtual methods
        ///	- should have constructors chaining(this (), base())
        ///	- at least one method with use of "base" keyword
        ///	- should have private/protected/public methods
        ///	- use object inializer
        ///	- classes should have properties and fields
        ///	- use static/readonly/const keywords
        ///	- NOT LIMITED BY ABOVE STATEMENTS

        ///Example: 
        ///Cars, Musical instruments, Shapes
        /// </summary>
        internal static void DoExample()
        {
            using (MusicInstrument guitar = new Guitar(1))
            {
                MusicInstrument.DoPlay(guitar);
            }
            using (MusicInstrument trembita = new SmallTrembita())
            {
                MusicInstrument.DoPlay(trembita);
            }
        }
    }
}