namespace BalatroHub.Services
{
    public class AppState
    {
        public string LastClickedSection { get; set; } = "None";
        public event Action OnChange;

        public void SetSection(string section)
        {
            LastClickedSection = section;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}