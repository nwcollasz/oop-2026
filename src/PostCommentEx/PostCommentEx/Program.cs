using PostCommentEx.Entities;

Comment c1 = new Comment("Have a nice trip!");
Comment c2 = new Comment("Wow that's awesome!");

Post p1 = new Post(
    "Vacation",
    "Traveling to New Zealand",
    DateTime.Parse("2026-07-23 23:05:44"),
    12
);
p1.AddComment(c1);
p1.AddComment(c2);


Comment c3 = new Comment("Good night bro");
Comment c4 = new Comment("Good night!!!");

Post p2 = new Post(
    "Good night",
    "See you tomorrow, bye!",
    DateTime.Parse("2026-07-23 23:05:44"),
    2
);
p2.AddComment(c1);
p2.AddComment(c2);

Console.WriteLine(p1);
Console.WriteLine(p2);