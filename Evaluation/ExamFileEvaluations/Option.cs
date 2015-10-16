namespace Telerik.ILS.Services.Courses.PracticalExams.CriteriaImporter
{
    public class Option
    {
        public Option(string name, decimal points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; private set; }

        public decimal Points { get; private set; }
    }
}
