using System;
using System.Text;
using System.Collections.Generic;
namespace FuncStringBld.Entities{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> comments{get;set;} = new List<Comment>();
        public Post(){

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }
        //ADD E REMOVE SÃO PADRÃO EM CLASSES COM COMPOSICAO DE OBJETOS DE 1 PARA MUITOS
        public void AddComment(Comment comment){
           comments.Add(comment);
        }
        public void RemoveComment(Comment comment){
            comments.Remove(comment);
        }
        public override string ToString(){
            //StringBuilder -> Resposável por fazer a montagem de uma string de forma eficiente. Tem várias operações para montar um texto
            //Append -> Adicionar um texto no fim de um StringBuilder
            //AppendLine -> Adiciona um texto no fim de um StringBuilder e quebra uma linha
            //StringBuilder -> pertence ao namespace System.Text;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in comments){
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}