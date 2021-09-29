using System;

namespace DIvanyshyn___Task_3
{

    internal class Task2
    {
        /// <summary>
        /// * Create types for storing tests. 
        ///Test should contain unique identifier and test question.
        ///There should be two types of tests: 
        ///	- CASE - select one correct answer from multiple cases.
        ///- JUST_STR - input correct answer
        /// Test should contain correct answer.
        ///Test should have method that returns if user answer is correct or not.
        /// * Store all tests in one container.
        ///* Print tests one by one and let user to type answer.
        ///Calculate amount of correct answers.

        /// </summary>
        internal static void DoExample()
        {
            //Sorry for this but that is just a test example
            Test test1 = new Test(
                new System.Collections.Generic.List<TestQuestion> {
                          new CaseTestQuestion(
                                new CaseAnswer[]{
                                    new CaseAnswer("One",true),
                                    new CaseAnswer("Two",false)
                                },questionString:"2-1?"),

                          new StringTestQuestion(answer:"Yes", questionString:"Will you drink coffe?")
                },
                name: "Testing test ");
            test1.DoTest();
        }

    }
}