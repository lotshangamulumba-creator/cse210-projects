using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        int minutes = _lengthSeconds / 60;
        Console.WriteLine($"Length: {minutes} min");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach(Comment C in _comments)
        {
            Console.WriteLine($"-{C.GetName()}: {C.GetText()}");
        }
        Console.WriteLine();
    }
        


}