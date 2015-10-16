namespace Telerik.ILS.Services.Courses.PracticalExams.CriteriaImporter
{
    using System.Collections.Generic;

    public class Criteria
    {
        public Criteria(string name, string description, List<Option> options)
        {
            this.Name = name;
            this.Description = description;
            this.Options = options;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public List<Option> Options { get; private set; }
    }
}
