var today = DateOnly.FromDateTime(DateTime.Now);
var today2 = new DateOnly(2002, 10, 21);
Console.WriteLine(today.Year-today2.Year);