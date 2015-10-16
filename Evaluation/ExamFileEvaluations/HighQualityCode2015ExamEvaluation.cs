namespace ExamFileEvaluations
{
    using System.Collections.Generic;
    using Telerik.ILS.Services.Courses.PracticalExams.CriteriaImporter;

    public static class HighQualityCode2015ExamEvaluation
    {
        public static List<Criteria> GetCriteria()
        {
            return new List<Criteria>
            {
                new Criteria("Refactoring (18)", string.Empty, new List<Option>()),
                new Criteria(
                    "Кодът се компилира успешно",
                    "Компилационните грешки са оправени",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Кодът се компилира без предупреждения (warnings)",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Всички файлове се намират в подходящо именуван namespace",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Повечето", 1.5m),
                        new Option("Някои", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "По-добро наименование на класове, променливи, полета, пропъртита, методи и параметри",
                    "Всяко име дава ясна представа за предназначението (не са 'r', 'PR', 'm' и т.н.)",
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("На повечето места", 2),
                        new Option("На някои места", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Класа HttpNotFound е преименуван на HttpNotFoundException",
                    "Спазвайки конвенцията за именуване на exceptions",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Изнесени са необходимите константи",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Частично", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "\"text/plain; charset=utf-8\" е изнесено като константа",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Премахната е излишната константа \"ClassName = \"HttpNotFoundException\"\"",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Премахнат е Middle man от кода",
                    "Например NewActionInvoker класа, който извиква ActionInvoker.InvokeAction",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Премахнат е дългият несвързан коментар в ActionInvoker",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Излишните парчета код са премахнати",
                    "Например файла var.cs, излишните usings в HttpResponse, класа HighQualityCodeExamPointsProvider и т.н.",
                    new List<Option>
                    {
                        new Option("Да", 2m),
                        new Option("Повечето", 1.5m),
                        new Option("Някои", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Divergent change - HttpRequest данните са разделени от логиката за парсване",
                    "Двете вече са в отделни класове (например данните в HttpRequest и трите метода за парсване в RequestParser)",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Логиката по обработката на заявките (ResponseProvider.Process) е отделена",
                    "Логиката за заявките (OPTIONS, HEAD, files, controllers) е изкарана в отделни самостоятелни методи или отделни класове",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Класа ParserException е изкаран извън HttpNotFound",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Метода GetContentType в HighQualityCodeExamPointsProvider е преместен в JsonActionResult",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Code duplicate - изкаран е базов клас за повтарящата се логика в HttpRequest и HttpResponse класовете",
                    "Например базов клас HttpMesssage, който съдържа AddHeader и повтарящата се логика в ToString", 
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),

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
                    "Например за декориране на ActionResult с CORS и no caching функционалности",
                    new List<Option>
                    {
                        new Option("Да", 6),
                        new Option("Частично", 3),
                        new Option("Не", 0),
                    }),

                new Criteria("Unit Testing (13)", "https://github.com/TelerikAcademy/High-Quality-Code-Exam-ConsoleWebServer/tree/CleanCode/ConsoleWebServer/ConsoleWebServer.Tests", new List<Option>()),
                new Criteria(
                    "ActionDescriptor.ctor() - тест проверяващ, че адресът се парсва успешно",
                    "Например new ActionDescriptor(\"/test/method/inputdata\"); и Assert за контролера, action-а и параметъра",
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ActionDescriptor.ctor() - тест проверяващ с null или string.Empty параметър",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ActionDescriptor.ctor() - тест проверяващ default стойностите на контролера",
                    "Например new ActionDescriptor(\"/\")",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ActionDescriptor.ctor() - тест проверяващ default стойностите на action-а",
                    "Например new ActionDescriptor(\"/test\")",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ActionDescriptor.ctor() - тест проверяващ default стойностите на параметъра",
                    "Например new ActionDescriptor(\"/test/method\");",
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ActionDescriptor.ctor() - има 100% Code Coverage",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.ReturnMe() - тест проверяващ, че се връща валиден резултат от метода",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.ReturnMe() - има 100% Code Coverage",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.GetDateWithCors() - тест проверяващ, че се връща правилна стойност при валиден хедър",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 2.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.GetDateWithCors() - тест проверяващ, че се хвърля exception при различен Referer от параметъра",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.GetDateWithCors() - тест проверяващ, че се хвърля exception при невалиден (празен или липсващ) хедър",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "ApiController.GetDateWithCors() - има 100% Code Coverage",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Използван е mocking с Moq в тестовете",
                    "Например за мокване на HttpHandler или IHttpHandler или нещо друго",
                    new List<Option>
                    {
                        new Option("Да, за поне 2 теста", 1),
                        new Option("Да, в 1 тест", 0.5m),
                        new Option("Не", 0),
                    }),

                new Criteria("Code Documentation (4)", string.Empty, new List<Option>()),
                new Criteria(
                     "Документиран ли е IActionResult интерфейса",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Документиран ли е методът IActionResult.GetResponse()",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                     "Документиран ли е IResponseProvider интерфейса",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Документиран ли е методът IResponseProvider.GetResponse()",
                    "Без правописни грешки, с ясен текст и добър английски език",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Да, но може и по-добре", 0.5m),
                        new Option("Не", 0),
                    }),

                new Criteria("Bug Fixing (11 или 12)", "https://github.com/TelerikAcademy/High-Quality-Code-Exam-ConsoleWebServer/commit/5d7d49cd82624b89e1baaad6818177ca32b642e5", new List<Option>()),
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
                        new Option("Оправен и описан", 2.5m),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 1.25m),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "Когато параметърът не е подаден по условие, трябва default стойността да е празен низ, а не 'Param'",
                    "Кодът трябва да е нещо като: this.Parameter = uriParts.Length > 2 ? uriParts[2] : string.Empty;",
                    new List<Option>
                    {
                        new Option("Оправен и описан", 2.5m),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 1.25m),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "Първият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за разлика. Липсата на '/Home/Forum/' също.",
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Вторият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за разлика. Липсата на '/Home/Forum/' също.",
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Bonus: Премахнато е throw new Exception() от конструктора на JsonActionResultWithoutCaching",
                    "Където и да е преместена логиката за JsonActionResultWithoutCaching (например в декоратора) не трябва да се хвърля ексепшън",
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),

                new Criteria("Performance Bottleneck (4 или 6)", string.Empty, new List<Option>()),
                new Criteria(
                    "Търсенето за съществуване на файл в StaticFileHandler е подобрено",
                    "Като е заменен бавния рекурсивния метод FileExists с бързия вграден File.Exists",
                    new List<Option>
                    {
                        new Option("Оправен и описан", 4),
                        new Option("Описан и неоправен, оправен и неописан или частично описан / оправен", 2),
                        new Option("Неописан и неоправен (ненамерен)", 0),
                    }),
                new Criteria(
                    "Bonus: Излишните извиквания на '.ToList().AsEnumerable().AsQueryable().ToArray()' са махнати",
                    "В класа ActionDescriptor",
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Не", 0),
                    }),

                new Criteria("New Features (11)", string.Empty, new List<Option>()),
                new Criteria(
                    "Имплементиран ли е HEAD handler, който да работи преди останалите условия за обработка на завката",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Имплементиран ли е RedirectActionResult клас, който да връща '302 Redirect' с Location header?",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 2),
                        new Option("Частично", 1m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Комбиниран ли е или може ли да се комбинира RedirectActionResult с CORS и no caching функционалностите?",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Частично", 0.5m),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Добавен ли е Redirect метод в класа Controller, който да връща нов RedirectActionResult?",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Добавен ли е Forum метод в класа HomeController, който да вика Redirect с адреса към форума?",
                    string.Empty,
                    new List<Option>
                    {
                        new Option("Да", 1),
                        new Option("Не", 0),
                    }),
                new Criteria(
                    "Третият примерен тест изкарва очаквания резултат",
                    "Датата и Content-Length-а не ги отчитаме за грешка. Липсата на '/Home/Forum/' също.",
                    new List<Option>
                    {
                        new Option("Да", 3),
                        new Option("Частично", 1.5m),
                        new Option("Не", 0),
                    }),

                new Criteria("SOLID (8)", string.Empty, new List<Option>()),
                new Criteria(
                    "Single Responsibility принцип",
                    "Всеки клас има само една причина за промяна",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 1),
                        new Option("Частично приложен / частично описан или приложен, но неописан", 0.5m),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Open / Closed принцип",
                    "Отворен за разширение, затворен за промяна",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан или приложен, но неописан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Liskov Substitution принцип",
                    "Наследниците успешно заменят базовите си класове",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан или приложен, но неописан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Interface Segregation принцип",
                    "Малки, точни и ясни интерфейси, дефиниращи едно единствено нещо",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 1),
                        new Option("Частично приложен / частично описан или приложен, но неописан", 0.5m),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
                new Criteria(
                    "Dependency Inversion принцип",
                    "Това, от което класовете зависят, им се подава от класовете, които ги използват",
                    new List<Option>
                    {
                        new Option("Добре приложен и описан", 2),
                        new Option("Частично приложен / частично описан или приложен, но неописан", 1),
                        new Option("Неописан и неприложен (липсващ)", 0),
                    }),
            };
        }
    }
}
