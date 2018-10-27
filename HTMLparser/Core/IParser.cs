using AngleSharp.Dom.Html;


namespace HTMLparser.Core
{
    interface IParser<T> where T:class
    {
        T Parse(IHtmlDocument document);


    }
}
