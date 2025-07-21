public class Comment
{
    private string _commentPerson; // tracking the person name who wrote the comment
    private string _commentText; // tracking the comment itself

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