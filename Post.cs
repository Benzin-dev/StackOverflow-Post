using System;

namespace StackOverflow_Post
{
    public class Post
    {
        // properties:  свойства класса:
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; private set; } // date can be set only inside and can't be changed. Дата не может быть изменена извне.
        public int Votes { get; private set; } // same

        // constructor: конструктор:
        public Post(string title, string description, string content)
        {
            Title = title;
            Description = description;
            Content = content;
            Created = DateTime.Now;
            Votes = 0;
        }

        // methods: методы:
        public void VoteUp()
        {
            Votes++;
        }

        public void VoteDown()
        {
            Votes--;
        }
    }
}
