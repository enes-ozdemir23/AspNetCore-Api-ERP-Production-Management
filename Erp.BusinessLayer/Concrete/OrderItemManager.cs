using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erp.BusinessLayer.Abstract;
using Erp.DataAccessLayer.Abstract;
using Erp.EntityLayer.Entities;

namespace Erp.BusinessLayer.Concrete
{
    public class OrderItemManager : IOrderItemService
    {
        private readonly IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public void TAdd(OrderItem entity)
        {
            _orderItemDal.Add(entity);
        }

        public void TDelete(OrderItem entity)
        {
            _orderItemDal.Delete(entity);
        }

        public OrderItem TGetByID(int id)
        {
            return _orderItemDal.GetByID(id);
        }

        public List<OrderItem> TGetListAll()
        {
            return _orderItemDal.GetListAll();
        }

        public void TUpdate(OrderItem entity)
        {
            _orderItemDal.Update(entity);
        }
    }
}
