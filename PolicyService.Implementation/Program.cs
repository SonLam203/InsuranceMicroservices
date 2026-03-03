var builder = WebApplication.CreateBuilder(args);

// ==================
// ADD SERVICES (PHẢI TRƯỚC Build())
// ==================

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddControllers();

// ==================
// BUILD APP
// ==================

var app = builder.Build();

// ==================
// CONFIGURE PIPELINE
// ==================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();