public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _lengthSeconds;
    private List<Comment> _allComments;


    public Video(string TITLE, string AUTHOR, int LENGTHSEC)
    {
        _videoTitle = TITLE;
        _videoAuthor = AUTHOR;
        _lengthSeconds = LENGTHSEC;
        _allComments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _allComments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _allComments.Count;
    }

    public string GetTitle()
    {
        return _videoTitle;
    }

    public string GetAuthor()
    {
        return _videoAuthor;
    }

    public int GetLengthSeconds()
    {
        return _lengthSeconds;
    }

    public List<Comment> GetComments()
    {
        return _allComments;
    }

}