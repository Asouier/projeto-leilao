﻿using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories
{
    public class StatusPropriedadeRepository : IStatusPropriedadeRepository
    {
        private readonly AppDbContext _context;

        public StatusPropriedadeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(StatusPropriedade statusPropriedade)
        {
            await _context.StatusPropriedades.AddAsync(statusPropriedade);
            await _context.SaveChangesAsync();
        }

        public async Task Update(StatusPropriedade statusPropriedade)
        {
            _context.StatusPropriedades.Update(statusPropriedade);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
            var statusPropriedade = await _context.StatusPropriedades.FindAsync(id);
            if (statusPropriedade != null)
            {
                _context.StatusPropriedades.Remove(statusPropriedade);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<StatusPropriedade?> GetById(int id)
        {
            return await _context.StatusPropriedades.FindAsync(id);
        }

        public async Task<List<StatusPropriedade>> GetAll()
        {
            return await _context.StatusPropriedades.ToListAsync();
        }
    }
}