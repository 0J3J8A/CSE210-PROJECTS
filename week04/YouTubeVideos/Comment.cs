public class Comment
{
    private string _commentPerson;
    private string _commentText;

    public Comment(string Name, string Text)
    {
        _commentPerson = Name;
        _commentText = Text;
    }

    public string GetCommentPerson()
    {
        return _commentPerson;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
}