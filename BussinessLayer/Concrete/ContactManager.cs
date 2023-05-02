using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _ıcontactDal;

        public ContactManager(IContactDal ıcontactDal)
        {
            _ıcontactDal = ıcontactDal;
        }

        public void Delete(Contact t)
        {
            _ıcontactDal.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _ıcontactDal.GetById(id);
        }

        public List<Contact> GetlistAll()
        {
            return _ıcontactDal.GetListAll();
        }

        public void Insert(Contact t)
        {
            _ıcontactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
