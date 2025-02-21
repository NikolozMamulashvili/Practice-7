namespace FileParser;
public class Program
{
    static void Main(string[] args)
    {
        var employeeList = FileParserService.ReadDataFromDB("DATADBCopy.txt");
        FileParserService.CreateTableStyledTXT(employeeList);
    }
}
