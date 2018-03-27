namespace Graphlax.IMDB
{
    public class IMDBGraphObject
        :GraphObject
    {
        public IMDBGraphObject()
        {
            
        }
        public IMDBGraphObject(GraphObject graphObject)
        {
            this.Description=graphObject.Description;
            this.Image=graphObject.Image;
            this.Site=graphObject.Site;
            this.Title=graphObject.Title;
            this.Type=graphObject.Type;
            this.Url=graphObject.Url;
        }
        [GraphElement]
        public Film Info { get; set; }
    }
}