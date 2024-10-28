using AurumVoteSystemServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
app.Run();
//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();
//app.MapRazorPages();
//// 컨트롤러 경로 매핑 설정
//app.MapControllers();
//app.Run();
