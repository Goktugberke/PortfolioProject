namespace MyPortfolio.DAL.Entities
{
    public class TodoList
    {
        public int ToDoListId { get; set; }
        public String Title { get; set; }
        public String ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
