using AurumVoteSystemServer.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<VotingService>();

// Add logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

// CORS 정책추가
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

// CORS 정책적용
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseStaticFiles(); // 정적 파일 제공 (wwwroot 폴더 사용)
app.UseRouting();
app.MapControllers();
app.MapRazorPages(); // Razor 페이지 라우팅

// 기본 페이지를 Blazor 클라이언트 앱으로 설정
app.MapFallbackToFile("index.html");

app.Run();