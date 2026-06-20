using Microsoft.Extensions.Logging;
using SchoolManagementApp.Models;
using SchoolManagementApp.Services;

namespace SchoolManagementApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();

        // Register Services
        builder.Services.AddSingleton<IDataService<AcademicSession>>(
            new LocalStorageService<AcademicSession>("sessions.json"));
        builder.Services.AddSingleton<IDataService<ClassSection>>(
            new LocalStorageService<ClassSection>("classsections.json"));
        builder.Services.AddSingleton<IDataService<Student>>(
            new LocalStorageService<Student>("students.json"));
        builder.Services.AddSingleton<IDataService<FeeRecord>>(
            new LocalStorageService<FeeRecord>("fees.json"));
        builder.Services.AddSingleton<IDataService<FeeHead>>(
            new LocalStorageService<FeeHead>("feeheads.json"));
        builder.Services.AddSingleton<IDataService<CommonFeeRule>>(
            new LocalStorageService<CommonFeeRule>("commonfeerules.json"));
        builder.Services.AddSingleton<IDataService<FeePaymentReceipt>>(
            new LocalStorageService<FeePaymentReceipt>("feepaymentreceipts.json"));
        builder.Services.AddSingleton<IDataService<Teacher>>(
            new LocalStorageService<Teacher>("teachers.json"));
        builder.Services.AddSingleton<IDataService<Attendance>>(
            new LocalStorageService<Attendance>("attendance.json"));
        // Add this line with other service registrations
        builder.Services.AddSingleton<IDataService<FeeStructure>>(
            new LocalStorageService<FeeStructure>("feestructure.json"));

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}