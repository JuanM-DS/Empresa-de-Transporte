namespace Repositoy.Interfaces
{
    public interface IRepositoryModelBase<T> : IRepositoryBase<T>
    {
        public Task<IEnumerable<T>> GetAvailableAsync();
        public Task<bool> ChangeTheStateAsync(int idModelMain, int? idModelSecond, int? idModelThird, bool Available);
    }
}
