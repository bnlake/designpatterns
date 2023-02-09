namespace chainofresponsibility.Models
{
    internal class Content
    {
        public string Title = String.Empty;
        public string Blurb = String.Empty;

        public override string ToString()
        {
            return $"Title: {this.Title} | Blurb: {this.Blurb}";
        }
    }
}
