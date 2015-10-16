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
                    "Например клас, който създава някакви обекти и имплементира интерфейс.",
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Частично", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Strategy",
                    "Например, където се подава интерфейс, вместо конкретен клас някъде, за да се свърши някаква работа",
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Template Method поне веднъж",
                    "Например, където част от работата е оставена на наследниците (имплементиран virtual или abstract метод)",
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Template Method втори път",
                    "Например, където част от работата е оставена на наследниците (имплементиран virtual или abstract метод)",
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е Chain of Responsibility",
                    "Например за веригата от условия при обработването на заявките (HEAD->OPTIONS->files->controller)",
                    new List<Option>
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
                new Criteria(
                     "Документиран ли е IActionResult интерфейса",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не (0)", 0),
                    }),
                new Criteria(
                    "Документиран ли е методът IActionResult.GetResponse()",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не (0)", 0),
                    }),
                new Criteria(
                     "Документиран ли е IResponseProvider интерфейса",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не (0)", 0),
                    }),
                new Criteria(
                    "Документиран ли е методът IResponseProvider.GetResponse()",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не (0)", 0),
                    }),

                new Criteria("Bug Fixing (11)", "https://github.com/TelerikAcademy/High-Quality-Code-Exam-ConsoleWebServer/commit/5d7d49cd82624b89e1baaad6818177ca32b642e5", new List<Option>()),
                new Criteria(
                    "Добавена е липсващaта ! при изписването на 'File not found'",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Оправен и описан", 2),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 1),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "При версия 3.0 на HTTP се връща 'Request cannot be handled' вместо 'Home page :)'",
                    "'request.ProtocolVersion.Major <= 3' е заменено с 'request.ProtocolVersion.Major < 3'",
                    new List<Option>
                    {
                        new Option("Оправен и описан", 3),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 1.5m),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "Когато параметърът не е подаден по условие, трябва default стойността да е празен низ, а не 'Param'",
                    "Кодът трябва да е нещо като: this.Parameter = uriParts.Length > 2 ? uriParts[2] : string.Empty;",
                    new List<Option>
                    {
                        new Option("Оправен и описан", 3),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 1.5m),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "Първият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за разлика. Липсата на '/Home/Forum/' също.",
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Вторият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за разлика. Липсата на '/Home/Forum/' също.",
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),

                new Criteria("Performance Bottleneck (4)", string.Empty, new List<Option>()),
                new Criteria(
                    "Търсенето за съществуване на файл в StaticFileHandler е подобрено",
                    "Като е заменен бавния рекурсивния метод FileExists с бързия вграден File.Exists",
                    new List<Option>
                    {
                        new Option("Оправен и описан", 4),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 2),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),

                new Criteria("New Features (11)", string.Empty, new List<Option>()),
                new Criteria(
                    "Третият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за грешка. Липсата на '/Home/Forum/' също.", new List<Option>
                    {
                        new Option("Да", 1), // 2?
                        new Option("Не", 0),
                    }),

                new Criteria("SOLID (8)", string.Empty, new List<Option>()),
                new Criteria(
                    "Single Responsibility принцип",
                    "Всеки клас има само една причина за промяна",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 1),
                        new Option("Частично приложен / частично описан", 0.5m),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Open / Closed принцип",
                    "Отворен за разширение, затворен за промяна",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Liskov Substitution принцип",
                    "Наследниците успешно заменят базовите си класове",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Interface Segregation принцип",
                    "Малки, точни и ясни интерфейси, дефиниращи едно единствено нещо",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 1),
                        new Option("Частично приложен / частично описан", 0.5m),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Dependency Inversion принцип",
                    "Това, от което класовете зависят, им се подава от класовете, които ги използват",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
            };
        }
    }
}
