namespace Asynchronous_Factory_Method
{
    public class Foo
    {
        public static async Task InitAsync()
        {
            await Task.Delay(1000);
        }
    }
}