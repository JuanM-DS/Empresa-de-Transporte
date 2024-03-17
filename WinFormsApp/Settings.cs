namespace WinFormsApp
{
    internal class Settings
    {
        public string SrtSqlServer { get; set; }

        public Settings()
        {
            SrtSqlServer = "Data Source=Pc\\MSSQLSERVER01;Initial Catalog=EmpresaDeTransporte;Integrated Security=True;TrustServerCertificate=True";

        }
    }
}