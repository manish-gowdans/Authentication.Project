namespace Authentication.Project.Infrastructure;

public class DatabaseSettings
{
    public string Host { get; set; }
    public int Port { get; set; }
    public string DatabaseName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string ConnectionString => $"Server={Host}:{Port};database={DatabaseName};user id={Username};password={Password};";
}
