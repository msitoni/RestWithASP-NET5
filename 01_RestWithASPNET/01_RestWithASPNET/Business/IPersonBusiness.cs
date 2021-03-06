using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01_RestWithASPNET.Data.VO;
using _01_RestWithASPNET.Model;

namespace _01_RestWithASPNET.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
