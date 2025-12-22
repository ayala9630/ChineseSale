using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly ChineseSaleContext _context;
        public CardRepository(ChineseSaleContext context)
        {
            _context = context;
        }
        //create
        public async Task AddCard(Card card)
        {
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<Card?> GetCard(int id)
        {
            return await _context.Cards.FirstOrDefaultAsync(x => x.Id == id);
        }
        //update
        public async Task UpdateCard(Card card)
        {
            _context.Cards.Update(card);
            await _context.SaveChangesAsync();
        }
    }
}