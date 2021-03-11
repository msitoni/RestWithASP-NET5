using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_RestWithASPNET.Data.VO;
using _01_RestWithASPNET.Model;

namespace _01_RestWithASPNET.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
