
using Microsoft.Extensions.DependencyInjection;
using StopBeingJerk.ApplicationLogic.Comments;

namespace StopBeingJerk.DI.ApplicationLogic
{
    public class CommentsDependencies
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddSingleton<ICommentService, CommentService>();
        }
    }
}
