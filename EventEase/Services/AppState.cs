namespace EventEase.Services
{
    public class AppState
    {
        public string CurrentUser { get; set; } = "Guest";
        public int TotalRegistered { get; set; } = 0;

        public event Action? OnChange;

        public void SetUser(string user)
        {
            CurrentUser = user;
            NotifyStateChanged();
        }

        public void IncrementAttendance()
        {
            TotalRegistered++;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
