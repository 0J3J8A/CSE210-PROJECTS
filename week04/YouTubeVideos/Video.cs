public class Video
{
    private string _videoTitle; // tracking title of the video
    private string _videoAuthor; // tracking author of the video
    private int _lengthSeconds; // traking length of the video in seconds
    private List<Comment> _allComments; // creating a list


    public Video(string TITLE, string AUTHOR, int LENGTHSEC)
    {
        _videoTitle = TITLE;
        _videoAuthor = AUTHOR;
        _lengthSeconds = LENGTHSEC;
        _allComments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _allComments.Add(comment); // store the coments
    }

    public int GetNumberOfComments()
    {
        return _allComments.Count; // return number of comments
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