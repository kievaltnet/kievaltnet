using MarkdownSharp;
namespace WebSite.Views
{
    public static class MarkdownExtensions
    {
        private static readonly Markdown Transformer = new Markdown();

        public static string RenderMarkdown(this string @this)
        {
            return Transformer.Transform(@this.Replace("\n", "\r\n\r\n"));
        }
    }
}