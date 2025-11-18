using Task_3;

ParameterDemo pd = new ParameterDemo();

int value = 5;
pd.Increase(ref value);
Console.WriteLine("After Increase: " + value);

pd.GetFullName(out string myname);
Console.WriteLine("Full Name: " + myname);

int total = pd.SumAll(1, 2, 3, 4);
Console.WriteLine("Sum: " + total);