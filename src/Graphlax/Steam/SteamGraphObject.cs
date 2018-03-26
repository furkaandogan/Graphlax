namespace Graphlax.Steam
{
    public class SteamGraphObject
        :GraphObject
    {
        [GraphElement]
        public Game Info { get; set; }
    }
}