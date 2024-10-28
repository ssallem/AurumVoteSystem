using AurumVoteSystemServer.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<VotingService>(); // VotingService 등록

// CORS 설정 추가
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

// CORS 정책 적용
app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();
app.UseStaticFiles(); // 정적 파일 사용 설정 (wwwroot 내 파일)
app.UseRouting();
app.MapControllers();
app.MapRazorPages(); // Razor 페이지를 사용 설정

// 기본 페이지로 Blazor 클라이언트 앱을 제공
app.MapFallbackToFile("index.html");

app.Run();