using api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Interfaces
{
    public interface Imember
    {
        void Update(Members member);
        Task<IEnumerable<Members>> GetMembersAsync();
        Task<bool> SaveAllAsync();
        Task<Members> GetMemberByIdAsync(int id);

        void SaveMember(Members member);
        void DeleTeMember(Members member);



    }
}
