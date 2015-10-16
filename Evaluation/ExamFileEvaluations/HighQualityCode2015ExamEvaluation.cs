namespace ExamFileEvaluations
{
    using System.Collections.Generic;

    public class HighQualityCode2015ExamEvaluation
    {
        public static List<Criteria> GetCriteria()
        {
            return new List<Criteria>
            {
                new Criteria("Refactoring (18)", string.Empty, new List<Option>()),

                new Criteria("StyleCop (9)", string.Empty, new List<Option>()),
                new Criteria(
                    "Колко предупреждения дава StyleCop",
                    "Пуснат върху целия solution",
                    new List<Option>
                    {
                        new Option("0 предупреждения", 9),
                        new Option("1 или 2 предупреждения", 8),
                        new Option("между 3 и 5 предупреждения, включително", 7),
                        new Option("между 6 и 8 предупреждения, включително", 6),
                        new Option("между 9 и 11 предупреждения, включително", 5),
                        new Option("между 12 и 15 предупреждения, включително", 4),
                        new Option("между 16 и 20 предупреждения, включително", 3),
                        new Option("между 21 и 29 предупреждения, включително", 2),
                        new Option("между 30 и 39 предупреждения, включително", 1),
                        new Option("40 и повече предупреждения", 0),
                    }),

                new Criteria("Design Patterns (22)", "Примери: https://github.com/TelerikAcademy/High-Quality-Code-Exam-ConsoleWebServer/blob/CleanCode/README.md", new List<Option>()),
                new Criteria(
                    "Използван е Factory Method",
                    "Например клас, който създава някакви обекти и имплементира интерфейс.", new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Частично", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Strategy",
                    "Например, където се подава интерфейс, вместо конкретен клас някъде, за да се свърши някаква работа", new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Template Method поне веднъж",
                    "Например, където част от работата е оставена на наследниците (имплементиран virtual или abstract метод)", new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Template Method втори път",
                    "Например, където част от работата е оставена на наследниците (имплементиран virtual или abstract метод)", new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Chain of Responsibility",
                    "Например за веригата от условия при обработването на заявките (HEAD->OPTIONS->files->controller)", new List<Option>
                    {
                        new Option("Да", 5),
                        new Option("Частично", 2.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Decorator",
                    "Например за декориране на ActionResult с CORS и no caching функционалности", new List<Option>
                    {
                        new Option("Да", 6),
                        new Option("Частично", 3),
                        new Option("Не", 0),
                    }),

                new Criteria("Unit Testing (13)", string.Empty, new List<Option>()),

                new Criteria("Code Documentation (4)", string.Empty, new List<Option>()),

                new Criteria("Bug Fixing (11)", string.Empty, new List<Option>()),

                new Criteria("Performance Bottleneck (4)", string.Empty, new List<Option>()),

                new Criteria("New Features (11)", string.Empty, new List<Option>()),

                new Criteria("SOLID (8)", string.Empty, new List<Option>()),
            };
        }
    }
}
