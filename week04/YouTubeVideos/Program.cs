using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video($"unboxing the new Phone", "TechGuy", 420);
        v1.AddComment(new Comment("Alice", "Great review!"));
        v1.AddComment(new Comment("Rone", "where can I buy it?"));
        v1.AddComment(new Comment("Carla", "I Love this song!"));

        Video v2 = new Video("Best sneakers 2026", "StyleHub" , 615);
        v2.AddComment(new Comment("Daniel", "Those red ones are pretty cool"));
        v2.AddComment(new Comment("Eva", "Too expensive for me :) "));
        v2.AddComment(new Comment ("Ange", "thanks for the comparison"));
        Video v3 = new Video("cooking with cast Iron" , "ChefMia", 780);
        v3.AddComment(new Comment("Elysa","I'm gonna try this tonight!"));
        v3.AddComment(new Comment("Ruth", "Nice pan, what brand? "));
        v3.AddComment(new Comment("Pretty", "cleaning tips please?"));
        List<Video> videos = new List<Video>{v1, v2, v3};
        foreach(Video video in videos)
        {
            video.Display();
        }

    }
}