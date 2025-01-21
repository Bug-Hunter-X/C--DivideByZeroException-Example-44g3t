public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DivideByZeroException caught: " + ex.Message);
            // Handle the exception appropriately, e.g., set a default value, log the error, etc.
        }
    }
} 
