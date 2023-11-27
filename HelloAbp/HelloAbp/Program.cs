using HelloAbp;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

var application =AbpApplicationFactory.Create<AppModule>();
application.Initialize();
var Service = application.ServiceProvider.GetService<HelloWorldService>();
Service.Run();