namespace TestNinja.Fundamentals
{
    public class ActionResult { }
    public class NotFound : ActionResult { }
    public class Ok : ActionResult { }
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return "<strong></strong>";

            return $"<strong>{content}</strong>";
        }
    }
}
