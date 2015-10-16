namespace ExamFileEvaluations
{
    using System;
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            var criteria = HighQualityCode2015ExamEvaluation.GetCriteria();
            Console.WriteLine($"Categories: {criteria.Count(x => !x.Options.Any())}");
            Console.WriteLine($"Questions: {criteria.Count(x => x.Options.Any())}");
            Console.WriteLine($"Options: {criteria.Sum(x => x.Options.Count)}");
            Console.WriteLine(
                $"Total points: {criteria.Sum(x => x.Options.Count == 0 ? 0 : x.Options.Max(opt => opt.Points))}");
            Console.WriteLine();
            for (var i = 0; i < criteria.Count;)
            {
                var criterion = criteria[i];
                if (!criterion.Options.Any())
                {
                    Console.Write(criterion.Name + " => ");
                }

                i++;

                var points = 0m;
                while (i < criteria.Count && criteria[i].Options.Any())
                {
                    points += criteria[i].Options.Max(x => x.Points);
                    i++;
                }

                Console.WriteLine(points);
            }
        }
    }
}
