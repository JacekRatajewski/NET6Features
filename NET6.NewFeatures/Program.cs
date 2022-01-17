//STRUCTS

var c1 = new Coords();
Console.WriteLine(c1);

var c2 = default(Coords);
Console.WriteLine(c2);

var coords = new Coords[2];
Console.WriteLine(string.Join(", ", coords));


//RECORDS

//var pA = new NonMutablePointA(0,1,2);
//pA.X = 1;
//Console.WriteLine(pA);

//var pB = new MutablePointB(0, 1, 2);
//pB.X = 1;
//Console.WriteLine(pB);

//var pC = new NonMutablePointC(0, 1, 2);
//pC.X = 1;
//Console.WriteLine(pC);

//var pD = pC with { X = 2 };
//Console.WriteLine(pD);

//EXTENDED PROPERTY PATTERN

//var date = new DateTime2(DateTime.Now);
//Console.WriteLine(DateTime2.IsToday(date));
//Console.WriteLine(date);

//CALLER ARGUMENT EXPRESSION
//CallerArgumentExpression.Validate(0 == 1);
//CallerArgumentExpression.Validate(0 == 1, "Nie działa");

//INITIALIZATION AND ASSIGMENT IN DECONSTRUCTION

//Declaring.Test();


//ARGUMENTNULLEXCPETION
//ArgumentNullException2.ThrowIfNull(null);
//ArgumentNullException.ThrowIfNull(null);

//HTTP3
//await new Http3().Request();

//PRIORITY QUEUE

//var queue = new PriorityQueue<string, int>();
//queue.Enqueue("Test", 1);
//queue.Enqueue("Test1", 3);
//queue.Enqueue("Test2", 0);
//Console.WriteLine(queue.Peek());

//JSON TREE
//new JsonTree().Test();

//DATE ONLY & TIME ONLY

//var date = new NET6.NewFeatures.NET6.DateOnly().Date;
//var time = new NET6.NewFeatures.NET6.TimeOnly().Time;

//Console.WriteLine(date);
//Console.WriteLine(time);