using Microsoft.Extensions.DependencyInjection;
using StopBeingJerk.ApplicationLogic.Topic;

namespace StopBeingJerk.DI.Dependencies
{
    public class TopicsDependencies
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton<ITopicService, TopicService>();
        }
    }
}
