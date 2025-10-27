namespace BlazorKurs257765.Components.Pages.Modul4
{
    public class ChatVM
    {
        public List<ChatModel> Liste { get; set; } = new();
        public event Action OnAdd;
        public void AddMessage(string name, string message)
        {
            Liste.Add(new ChatModel { Name = name, Message = message });
            OnAdd?.Invoke();
        }
    }
}
