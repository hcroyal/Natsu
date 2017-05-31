namespace Natsu.MyClass
{
    internal class Global
    {
        public static DataBPODataContext DbBpo = new DataBPODataContext();
        public static DataNatsuDataContext Db = new DataNatsuDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = "";
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string StrToken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.248\Natsu_Sokatu$";
        public static string Webservice = "http://10.10.10.248:8888/Natsu_Sokatu/";
        public static string StrIdProject = "Sokatu";
        public static int FreeTime = 0;
    }
}