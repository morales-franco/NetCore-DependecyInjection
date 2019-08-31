using NetCoreEssential.DependencyInjection.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreEssential.DependencyInjection.Services
{
    class ReaderService: IReaderService
    {
        private readonly string _favouriteBook;

        public ReaderService(string favouriteBook)
        {
            _favouriteBook = favouriteBook;
        }

        public string GetFavouriteBook()
        {
            return _favouriteBook;
        }
    }
}
