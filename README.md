###Design pattern: Factory Method
	* 

###Design pattern: Strategy
	* 

###Design pattern: Template Method
	* 
	* 

###Design pattern: Chain of Responsibility
	* 

###Design pattern: Decorator
	* 

###Found bugs:
	* When file is not found the message should be "File not found!" instead of "File not found"
	* When protocol version is 3.0 the response should be "501 NotImplemented Request cannot be handled." instead of "200 OK". This is fixed by fixed by replacing `request.ProtocolVersion.Major <= 3;` with `request.ProtocolVersion.Major < 3;`
	* When default parameter is not specified the parameter value should be `string.Empty` instead of `Param`
    More info about the introduced bugs: https://github.com/NikolayIT/High-Quality-Code-Exam-ConsoleWebServer/commit/5d7d49cd82624b89e1baaad6818177ca32b642e5

###Found bottleneck:
	* 

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
