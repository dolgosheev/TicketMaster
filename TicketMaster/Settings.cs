namespace TicketMaster
{
    internal static class Settings
    {

        public static string Resource { get; } = "http://app.ticketmaster.com";
        public static string Package { get; } = "discovery";
        public static string ApiVersion { get; } = "v2";
        public static string ApiResource { get; } = "attractions";
        
        // example request
        public static string Additionalfilters { get; set; } = "keyword=football";
        public static string ApiKey { get; } = "zHYNxpjzzDmWaQ7k49LL2DPOcDPkQPbh";


        private static readonly string RootApiRequestString = string.Join('/', Resource, Package, ApiVersion, ApiResource);

        public static string ApiRequestString = string.Concat(RootApiRequestString, ".json?", Additionalfilters, "&apikey=",ApiKey);

    }
}
