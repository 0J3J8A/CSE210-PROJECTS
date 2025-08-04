using System;

class MusicalGoal : Goal
{
    private string _instrument;
    private string _songName;
    private string _author;
    private DateTime _targetDate;
    private bool _isComplete;

    public MusicalGoal(string name, string description, int points, string instrument, 
                      string songName, string author, DateTime targetDate) 
        : base(name, description, points)
    {
        _instrument = instrument;
        _songName = songName;
        _author = author;
        _targetDate = targetDate;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        string dateStr = _targetDate.ToString("yyyy-MM-dd");
        return $"{status} {_shortName}: {_description} (Instrument: {_instrument}, Song: {_songName} by {_author}, Target Date: {dateStr})";
    }

    public override string GetStringRepresentation()
    {
        return $"MusicalGoal|{_shortName}|{_description}|{_points}|{_instrument}|{_songName}|{_author}|{_targetDate}|{_isComplete}";
    }
}