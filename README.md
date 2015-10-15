###Design pattern: Factory Method
* 

###Design pattern: Strategy
* 

###Design pattern: Template Method
* 
* 

###Design pattern: Chain of Responsibility
* The abstract class `Handler` have `HandleRequest` method which accepts `HttpRequest` and returns `HttpResponse` and also have `SetSuccessor(Handler successor)` method to receive the next element of the chain. All implementations of the `Handler` class (`ControllerHandler`, `HeadHandler`, `OptionsHandler` and `StaticFileHandler`) are chained in the `HandlerFactory` class using the `SetSuccessor` method.

More info: https://github.com/NikolayIT/High-Quality-Code-Exam-ConsoleWebServer/commit/a755175825e2bb1378c8fe90a3efbbfc61e879a8

###Design pattern: Decorator
* The abstract `ActionResultDecorator` class implements `IActionResult` and has a field `actionResult` of type `IActionResult`. The classes `ActionResultWithCorsDecorator` and `ActionResultWithNoCachingDecorator` (the concrete decorators) "decorates" IActionResult, adding additional functionality (headers).

More info: https://github.com/NikolayIT/High-Quality-Code-Exam-ConsoleWebServer/commit/745394da9f032185117cb2fa0d8feb48be30edce

###Found bugs:
* When file is not found the message should be `File not found!` instead of `File not found` (the difference is the `!` sign)
* When protocol version is 3.0 the response should be `501 NotImplemented Request cannot be handled.` instead of `200 OK`. This is fixed by replacing `request.ProtocolVersion.Major <= 3;` with `request.ProtocolVersion.Major < 3;`
* When default parameter is not specified the parameter value should be `string.Empty` instead of `Param`

More info about the introduced bugs: https://github.com/NikolayIT/High-Quality-Code-Exam-ConsoleWebServer/commit/5d7d49cd82624b89e1baaad6818177ca32b642e5

###Found bottleneck:
* In `StaticFileHandler` the slow recursive method `FileExists(string path, string filePath, int depth)` is replaced with call to `File.Exists(filePath)`

More info about the bottleneck: https://github.com/NikolayIT/High-Quality-Code-Exam-ConsoleWebServer/commit/a26aab61abab219f68e7b728d0f7891764f4597a

###Single responsibility principle
* 

###Open/closed principle
* 

###Liskov substitution principle
* 

###Interface segregation principle
* 

###Dependency inversion principle
* 
