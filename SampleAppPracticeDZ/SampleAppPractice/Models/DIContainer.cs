using Autofac;

namespace SampleAppPractice.Models
{
    public class DIContainer
    {
        private static IContainer container;

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SmtpMessage>().As<IMessage>();
            builder.RegisterType<OtherMessage>().As<IMessage>();

            container = builder.Build();
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }
    }
}
