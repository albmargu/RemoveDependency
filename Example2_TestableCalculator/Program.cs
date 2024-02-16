using Example2;

var calculator = new Calculator(4, 5, new Operator(), new Dependency());
Console.WriteLine("Example 2 Results");
Console.WriteLine("Method1: " + calculator.Method1());
Console.WriteLine("Method2: " + calculator.Method2());
Console.WriteLine("Method3: " + calculator.Method3());