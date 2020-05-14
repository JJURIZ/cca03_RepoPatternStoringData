using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ITelegramRepository
    {
        List<Telegram> ListAll();
        Telegram GetById(int id);
        void Add(Telegram newTelegram);
        void Edit(Telegram editedTelegram);
        void Delete(Telegram telegramDelete);
    }
}
