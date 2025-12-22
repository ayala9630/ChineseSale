using System;

namespace ChineseSaleApi.Dto
{
    public class CardDto
    {
        public int Id { get; set; }
        public bool? IsWin { get; set; }
        public int UserId { get; set; }
        public int GiftId { get; set; }
    }
}