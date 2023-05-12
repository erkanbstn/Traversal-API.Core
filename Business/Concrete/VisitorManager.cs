using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VisitorManager : IVisitorService
    {
        IVisitorDal _visitorDal;

        public VisitorManager(IVisitorDal visitorDal)
        {
            _visitorDal = visitorDal;
        }

        public void YouCanDelete(Visitor t)
        {
            _visitorDal.Delete(t);
        }

        public Visitor YouCanGetById(int id)
        {
            return _visitorDal.GetById(id);
        }

        public void YouCanInsert(Visitor t)
        {
           _visitorDal.Insert(t);
        }

        public List<Visitor> YouCanList()
        {
           return _visitorDal.GetList();
        }

        public void YouCanUpdate(Visitor t)
        {
           _visitorDal.Update(t);
        }
    }
}
