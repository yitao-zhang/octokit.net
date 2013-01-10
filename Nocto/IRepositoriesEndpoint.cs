using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Nocto
{
    public interface IRepositoriesEndpoint
    {
        /// <summary>
        /// Retrieves the <see cref="Repository"/> for the specified owner and name.
        /// </summary>
        /// <param name="owner">The owner of the repository.</param>
        /// <param name="name">The name of the repository.</param>
        /// <returns>A <see cref="Repository"/></returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<Repository> Get(string owner, string name);

        Task<PagedList<Repository>> GetAll(RepositoryQuery query);
    }
}