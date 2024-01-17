using SampleAppPractice.Models;

DIContainer.Configure();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMessanger, Messanger>();
builder.Services.AddScoped<IFactory, MessageFactory>();
builder.Services.AddScoped<IClient, SmtpClient>(); //zatem sdelat IClient, SmtpClient, kak stroka #5
builder.Services.AddScoped<SmtpSettings>(_ =>
    new SmtpSettings()
    {
        Host = "smtp.example.com",
        Port = 25
    }  
);


//var messageFactory = new MessageFactory();
//var settings = new SmtpSettings()
//{
//    Host = "smtp.example.com",
//    Port = 25
//};
//var smtpClient = new SmtpClient(settings);
//var messanger = new Messanger(smtpClient, messageFactory);

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();
