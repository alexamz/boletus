using Boletus;

class Program
{
    static async Task Main(string[] args)
    {

        try
        {
            //var host = Boletus.HostBuilder.CreateHostBuilder();

            //await host.Build().RunAsync();

            var host = Host
                .CreateDefaultBuilder()
                .ConfigureServices(services => services.AddHostedService<Worker>())
                .Build();

            await host.RunAsync();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {

        }
    }
}