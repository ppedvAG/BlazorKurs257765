namespace BlazorKurs257765.Components.Pages.Modul4
{
    public class ToDoVM
    {
        public ToDoModel toDos { get; set; }
        public ToDoVM(IHttpClientFactory _http) { 
            using (var client = _http.CreateClient())
            {
                var response = client.GetAsync("https://dummyjson.com/todos?limit=300").Result;
                if (response.IsSuccessStatusCode)
                {
                    toDos = response.Content.ReadFromJsonAsync<ToDoModel>().Result;
                }
                else
                {
                    ErrorMessage = $"Fehler beim Laden der ToDos: {response.ReasonPhrase}";
                }
            }

        }
        public string ErrorMessage { get; set; }
    }
}
