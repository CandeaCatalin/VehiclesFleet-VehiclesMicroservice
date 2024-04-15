namespace VehiclesMicroservice.Settings;

public static class AppSettingsConstants
{
    public static class Section
    {
        public const string Database = "Database";
        public const string Authorization = "Authorization";
        public const string LoggerMicroserviceSectionName = "LoggerMicroservice";
        public const string RunningConfigurationSectionName = "RunningConfiguration";
    }

    public static class Keys
    {
        public const string ConnectionString = "ConnectionString";
        public const string JwtSecretKey = "JwtSecretKey";
        public const string LogInfoUrlKey = "LogInfoUrl";
        public const string LogErrorUrlKey = "LogErrorUrl";
        public const string ApplicationNameKey = "ApplicationName";
    }
}