using ChineseSaleApi.Data;
using ChineseSaleApi.Models;
using ChineseSaleApi.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace ChineseSaleApi.Repositories
{
    public class CardCartRepository : ICardCartRepository
    {
        private readonly ChineseSaleContext _context;
        public CardCartRepository(ChineseSaleContext context)
        {
            _context = context;
        }
        //create
        public async Task AddCardCart(CardCart cardCart)
        {
            _context.CardCarts.Add(cardCart);
            await _context.SaveChangesAsync();
        }
        //read
        public async Task<IEnumerable<CardCart>> GetAllCardCarts()
        {
            return await _context.CardCarts.ToListAsync();
        }
        public async Task<CardCart?> GetCardCart(int id)
        {
            return await _context.CardCarts.FirstOrDefaultAsync(x => x.Id == id);
        }
        //update
        public async Task UpdateCardCart(CardCart cardCart)
        {
            _context.CardCarts.Update(cardCart);
            await _context.SaveChangesAsync();
        }
        //delete
        public async Task DeleteCardCart(int id)
        {
            var cardCart = await _context.CardCarts.FirstOrDefaultAsync(x => x.Id == id);
            if (cardCart != null)
            {
                _context.CardCarts.Remove(cardCart);
                await _context.SaveChangesAsync();
            }
        }

    }
}