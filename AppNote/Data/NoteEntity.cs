using AppNote.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNote.Data
{
    public class NoteEntity : IDataHelper<Note>
    {
        private DBContext db;

        public NoteEntity() { db = new DBContext(); }

        public async Task AddDataAsync(Note table)
        {
            await db.Notes.AddAsync(table);
            await db.SaveChangesAsync();
        }

        public async Task<Note> FindAsync(int Id)
        {
           return await db.Notes.FindAsync(Id);
        }

        public async Task<List<Note>> GetAllAsync()
        {
            return await db.Notes.ToListAsync();

        }

        public async Task RemoveDataAsync(Note table)
        {
           db.Notes.Remove(table);
            await db.SaveChangesAsync();
        }

        public async Task UpdateDataAsync(Note table)
        {
            db = new DBContext();
            db.Notes.Update(table);
            await db.SaveChangesAsync();
        }
    }
}
