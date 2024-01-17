namespace SampleAppPractice.Models
{
    public class MessageFactory : IFactory
    {
        public IMessage Create(string message)
        {
            //return new SmtpMessage() { Body = message };

            var messageInstance = DIContainer.Resolve<IMessage>();
            messageInstance.Body = message;

            return messageInstance;
        }
    }
}
