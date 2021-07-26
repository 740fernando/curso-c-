using StringBuilder1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sb.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set  } = new List<Comment>();
        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();//StringBuilder é responsável de montar o string na forma que voce quiser atraves de operações, pertence ao namespace System.Text
            sb.AppendLine(Title);//Append- Adiciona mais texto no final e uma quebra de linha
            sb.Append(Likes);//Append= Adiciona um texto no fim do String Builder
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments : ");
            foreach(Comment c in Comments)// Vai percorrer a lista de comments

            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }

    }
}
