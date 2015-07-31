namespace ExceptionsHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;

        private const int BadGradeMaxProblems = 2;
        private const int AverageGradeMaxProblems = 5;

        private const string BadResultComment = "Bad result: nothing solved.";
        private const string AverageResultComment = "Average result: half solved.";
        private const string ExcellentResultComment = "Excellent result: everything solved.";

        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }
        
        public int ProblemsSolved
        {
            get 
            {
                if (this.problemsSolved < MinProblemsSolved)
                {
                    return MinProblemsSolved;
                }
                else if (this.problemsSolved > MaxProblemsSolved)
                {
                    return MaxProblemsSolved;
                }
                else
                {
                    return this.problemsSolved;
                }
            }

            private set 
            { 
                this.problemsSolved = value; 
            }
        }

        public override ExamResult Check()
        {
            string comment;

            if (this.ProblemsSolved <= BadGradeMaxProblems)
            {
                comment = BadResultComment;
            }
            else if (this.ProblemsSolved <= AverageGradeMaxProblems)
            {
                comment = AverageResultComment;
            }
            else
            {
                comment = ExcellentResultComment;
            }

            return new ExamResult(this.ProblemsSolved, MinProblemsSolved, MaxProblemsSolved, comment);
        }
    }
}