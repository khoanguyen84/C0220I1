using System;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ForumManagement
{
    class Forum
    {
        public SortedList<int, Post> Posts;

        public Forum()
        {
            Posts = new SortedList<int, Post>();
            //Posts.Add(1, new Post()
            //{
            //    Author = "Khoa",
            //    Content = "Module 2",
            //    Id = 1,
            //    Title = "C#"
            //});
            //Posts.Add(2, new Post()
            //{
            //    Author = "Phap",
            //    Content = "Module 3",
            //    Id = 2,
            //    Title = "MVC"
            //});
        }

        public void Add(Post post)
        {
            Posts.Add(post.Id, post);
        }

        public void Update(string content, int postId)
        {
            if (CheckPost(postId))
            {
                Posts[postId].Content = content;
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }

        public void Remove(int postId)
        {
            if (CheckPost(postId))
            {
                Posts.RemoveAt(postId-1);
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }

        public void Show()
        {
            foreach(var post in Posts.Values)
            {
                Console.WriteLine(post.Display());
            }
        }

        public void Search(string keyword)
        {
            bool found = false;
            keyword = keyword.ToLower();
            foreach(var post in Posts.Values)
            {
                if(post.Author.ToLower().Contains(keyword) 
                    || post.Title.ToLower().Contains(keyword))
                {
                    Console.WriteLine(post.Display());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found");
            }
        }

        public void Rating(int postId, int rate)
        {
            if (CheckPost(postId))
            {
                Posts[postId].Rates.Add(rate);
            }
            else
            {
                Console.WriteLine("Invalid Post");
            }
        }

        private bool CheckPost(int postId)
        {
            //return Posts.Keys.Contains(postId);
            foreach(var post in Posts.Values)
            {
                if (post.Id == postId)
                    return true;
            }
            return false;
        }
    }
}
