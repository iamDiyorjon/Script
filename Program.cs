namespace Script;

public class Program
{
    public static string connectionString = "Database";
    public static string districtQuery = "query";
    public static string regionQuery = "Path";
    public static string excelPath = @"Path";
    public static HashSet<string> Region { get; set; } = new HashSet<string>();
    public static void Main(string[] args)
    {
        //#region District
        //NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        //connection.Open();
        //string textpath = @"C:\Users\User\Desktop\insert into district.txt";

        //int id = 215;

        //string district = string.Empty;
        //string region = string.Empty;
        //string subRegion = string.Empty;
        //string soat = string.Empty;
        //string codeSoat = string.Empty;
        //string roamingCode = string.Empty;
        //int regionId = 0;
        //int districtId = 0;
        //int sectorId = 0;
        //string mahallId = string.Empty;
        //string mahalla = string.Empty;
        //FileInfo excelFile = new FileInfo(excelPath);
        //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //List<string> list = new List<string>();
        //string answer = string.Empty;
        //using (ExcelPackage package = new ExcelPackage())
        //{
        //    package.Load(excelFile.OpenRead());
        //    var worksheet = package.Workbook.Worksheets[0];
        //    int rowCount = worksheet.Dimension.Rows;
        //    for (int row = 2; row <= rowCount; row++)
        //    {
        //        if (row == 3439)
        //            row = 3469;
        //        if (row == 6225)
        //            row = 6810;


        //        region = worksheet.Cells[row, 3].Value?.ToString();
        //        subRegion = region.Substring(0, region.IndexOf(' '));

        //        soat = worksheet.Cells[row, 4].Value?.ToString();
        //        codeSoat = soat.Substring(2);
        //        district = worksheet.Cells[row, 6].Value?.ToString();


        //        mahallId = worksheet.Cells[row, 9].Value?.ToString();
        //        if (mahallId.Length > 4)
        //        {
        //            roamingCode = mahallId.Substring(0, 4);

        //        }
        //        else
        //        {
        //            roamingCode = mahallId;
        //        }

        //        if (district[0] == 'г')
        //        {
        //            int index = district.IndexOf(' ') - 2;
        //            if (index > 0)
        //            {
        //                district = district.Substring(2, index);
        //            }
        //            district = district.Substring(2);

        //        }
        //        else
        //        {
        //            int index = district.IndexOf(' ');
        //            if (index > 0)
        //            {
        //                district = district.Substring(0, index);
        //            }
        //            district = district.Substring(0);
        //        }

        //        if (Region.Add($"{district}"))
        //        {


        //            NpgsqlCommand districtCommand = new NpgsqlCommand(districtQuery, connection);
        //            districtCommand.Parameters.AddWithValue("@substring", $"{district}");
        //            var districtReader = districtCommand.ExecuteReader();


        //            if (!districtReader.Read())
        //            {

        //                districtReader.Close();
        //                connection.Dispose();
        //                connection = new NpgsqlConnection(connectionString);
        //                connection.Open();
        //                NpgsqlCommand regionCommand = new NpgsqlCommand(regionQuery, connection);
        //                regionCommand.Parameters.AddWithValue("@substring", $"{subRegion}");
        //                var regionReader = regionCommand.ExecuteReader();
        //                regionReader.Read();
        //                regionId = regionReader.GetInt32(0);

        //                answer = $"({id}, '{id}', '{codeSoat}', '{soat}', '{roamingCode}', '{district}', '{district}', {regionId}, 1),";
        //                list.Add(answer);
        //                id++;
        //                Console.WriteLine($"({id}, '{id}', '{codeSoat}', '{soat}', '{roamingCode}', '{district}', '{district}', {regionId}, 1),");
        //                connection.Dispose();
        //                connection = new NpgsqlConnection(connectionString);
        //                connection.Open();
        //                districtCommand.Dispose();
        //                continue;
        //            }


        //            connection.Dispose();
        //            connection = new NpgsqlConnection(connectionString);
        //            connection.Open();
        //            districtCommand.Dispose();
        //        }


        //    }
        //    File.AppendAllLines(textpath, list);
        //    #endregion



        //    #region Mfy
        //    NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        //    connection.Open();

        //    string textpath = @"C:\Users\User\Desktop\insert into info_mfy .sql";
        //    string soat = string.Empty;
        //    string codeSoat = string.Empty;
        //    int regionId = 0;
        //    int id = 0;
        //    int sectorId = 0;
        //    string mahallId = string.Empty;
        //    string sector = string.Empty;
        //    string inn = string.Empty;
        //    string mahalla = string.Empty;
        //    FileInfo excelFile = new FileInfo(excelPath);
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    List<string> list = new List<string>();
        //    string answer = string.Empty;
        //    using (ExcelPackage package = new ExcelPackage())
        //    {
        //        package.Load(excelFile.OpenRead());
        //        var worksheet = package.Workbook.Worksheets[0];
        //        int rowCount = worksheet.Dimension.Rows;
        //        for (int row = 2; row <= rowCount; row++)
        //        {
        //            NpgsqlCommand command = new NpgsqlCommand(districtQuery, connection);
        //            if (row == 4084)
        //                row = 4137;


        //            soat = worksheet.Cells[row, 4].Value?.ToString();
        //            codeSoat = soat.Substring(2);

        //            sector = worksheet.Cells[row, 7].Value?.ToString();
        //            mahallId = worksheet.Cells[row, 9].Value?.ToString();
        //            mahalla = worksheet.Cells[row, 10].Value?.ToString();
        //            inn = worksheet.Cells[row, 11].Value?.ToString();
        //            if (row == 14)
        //                Console.WriteLine(inn);


        //            if (Region.Add($"{codeSoat}"))
        //            {
        //                command.Parameters.AddWithValue("@substring", $"{codeSoat}");
        //                NpgsqlDataReader reader = command.ExecuteReader();


        //                if (reader.Read())
        //                {
        //                    id = reader.GetInt32(0);
        //                    regionId = reader.GetInt32(1);
        //                }

        //                reader.Close();
        //                command.Dispose();
        //                connection.Dispose();
        //                connection = new NpgsqlConnection(connectionString);
        //                connection.Open();
        //            }



        //            int.TryParse(sector[0].ToString(), out sectorId);
        //            if (inn is not null)
        //            {
        //                if (sectorId == 1)
        //                    sectorId = 6;
        //                else if (sectorId == 2)
        //                    sectorId = 7;
        //                else if (sectorId == 3)
        //                    sectorId = 8;
        //                else if (sectorId == 4)
        //                    sectorId = 9;
        //                answer = $"({id},{regionId},{sectorId},1,'{mahallId}','{inn}','00{row - 1}','00{row - 1}','{mahalla}','{mahalla}'),";
        //                list.Add(answer);
        //                Console.WriteLine($"({id},{regionId},{sectorId},1,'{mahallId}','{inn}','00{row - 1}','00{row - 1}','{mahalla}','{mahalla}'),");
        //            }
        //            else
        //            {
        //                if (sectorId == 1)
        //                    sectorId = 6;
        //                else if (sectorId == 2)
        //                    sectorId = 7;
        //                else if (sectorId == 3)
        //                    sectorId = 8;
        //                else if (sectorId == 4)
        //                    sectorId = 9;
        //                answer = $"({id},{regionId},{sectorId},1,'{mahallId}',null,'00{row - 1}','00{row - 1}','{mahalla}','{mahalla}'),";
        //                list.Add(answer);
        //                Console.WriteLine($"({id},{regionId},{sectorId},1,'{mahallId}',null,'00{row - 1}','00{row - 1}','{mahalla}','{mahalla}'),");
        //            }
        //        }
        //        File.AppendAllLines(textpath, list);
        //    }

        //    Console.ReadKey();
        //    #endregion
    }
}