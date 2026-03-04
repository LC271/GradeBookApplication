using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool waga) : base(name, waga)
        {
            Type = GradeBookType.Standard;
        }
    }
}