using Order_API;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddSingleton(ConnectionMultiplexer.Connect("localhost,abortConnect=false"))
    .AddSingleton<OrderRepository>()
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .PublishSchemaDefinition(c => c
            .SetName("order")
            //.IgnoreRootTypes()
            .AddTypeExtensionsFromFile("./Stitching.graphql")
            .PublishToRedis("gateway", sp => sp.GetRequiredService<ConnectionMultiplexer>()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/order-api/graphql");

app.Run();
