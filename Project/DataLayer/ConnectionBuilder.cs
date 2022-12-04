using System.Data.SqlClient;

namespace DataLayer
{
    public static class ConnectionBuilder
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "dbsys.cs.vsb.cz\\STUDENT";
            builder.UserID = "RUB0031";
            builder.Password = "KtRM4cVVb01WatCx";
            builder.InitialCatalog = "RUB0031";
            builder.TrustServerCertificate = true;

            return builder;
        }
    }
}
