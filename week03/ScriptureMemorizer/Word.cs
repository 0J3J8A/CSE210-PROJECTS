class Word
{
    private string _text;
    private bool _occult;

    public Word(string text)
    {
        _text = text;
        _occult = false;
    }

    public void Hide()
    {
        _occult = true;
    }

    public bool Hidden()
    {
        return _occult;
    }

    public string GetDisplayText()//GETTER
    {
        return _occult ? new string('_', _text.Length) : _text;
    }
}