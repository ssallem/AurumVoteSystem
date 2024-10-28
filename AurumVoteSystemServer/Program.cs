using AurumVoteSystemServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
//// ��Ʈ�ѷ� ��� ���� ����
//app.MapControllers();
//app.Run();
