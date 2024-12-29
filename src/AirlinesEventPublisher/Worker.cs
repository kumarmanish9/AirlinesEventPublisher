using AirlineCoreLibrary.Service;

namespace AirlinesEventPublisher
{
    public class Worker(IEventPublisher publisher) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Simulate a flight event
                await publisher.PublishFlightEventAsync();

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
