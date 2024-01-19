namespace Common.Infrastructure
{
    /// <summary>
    /// Static class with the different application specific services registered in the ServicesDiscovery.
    /// The string values must match the Name under which each service was registered. 
    /// </summary>
    public static class ServicesDiscoveryNames
    {
        public const string SwarmBot = "SwarmBot";
        public const string Members = "Members";
    }
}
