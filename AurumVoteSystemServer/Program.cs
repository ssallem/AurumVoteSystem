using AurumVoteSystemServer.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<VotingService>(); // VotingService ���

// CORS ���� �߰�
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// CORS ��å ����
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseStaticFiles(); // ���� ���� ��� ���� (wwwroot �� ����)
app.UseRouting();
app.MapControllers();
app.MapRazorPages(); // Razor �������� ��� ����

// �⺻ �������� Blazor Ŭ���̾�Ʈ ���� ����
app.MapFallbackToFile("index.html");

app.Run();