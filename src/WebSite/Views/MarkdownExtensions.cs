using MarkdownSharp;
namespace WebSite.Views
{
    public static class MarkdownExtensions
    {
        private static readonly Markdown Transformer = new Markdown(new MarkdownOptions 
        {
            AutoHyperlink = true,
            AutoNewLines = true
        });
        
        public static string RenderMarkdown(this string @this)
        {            
            return Transformer.Transform(@this);
        }
    }
}