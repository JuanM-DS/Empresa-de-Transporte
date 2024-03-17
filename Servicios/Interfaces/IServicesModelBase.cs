namespace Services.Interfaces
{
    public interface IServicesModelBase<T> : IServicesBase<T>
    {
        public Task<IEnumerable<T>> GetAvailableAsync();
        public Task<bool> ChangeTheStateAsync(int idModelMain, int idModelSecond, int idModelThird, bool available);
    }
}
