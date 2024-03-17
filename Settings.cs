using System;

public class Settings
{
    public string SrtSqlServer { get; set; }

	public Settings()
	{
        SrtSqlServer = "Data Source=Pc\\MSSQLSERVER01;Inital Catalog=EmpresaDeTransporte;Integrated Scurity=True"
    }
}