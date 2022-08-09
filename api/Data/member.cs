using api.Entities;
using api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Data
{
    public class member : Imember
    {
        private readonly DataContext _context;

        public member(DataContext context)

        {
           _context = context;
        }

        public void DeleTeMember(Members member)
        {
            _context.Remove(member);
            _context.SaveChanges(); 
        }

        public async Task<Members> GetMemberByIdAsync(int id)
        {
           return await _context.Member.FindAsync(id);
        }

        public async Task<IEnumerable<Members>> GetMembersAsync()
        {
            return await _context.Member.ToListAsync();
        }

      

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void SaveMember(Members member)
        {
           _context.Member.Add(member);
            _context.SaveChanges();
        }

        public void Update(Members member)
        {
            _context.Update(member);
            _context.SaveChanges();
        }
    }
}

