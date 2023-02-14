using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    //manera difícil, pero mejor. está en uno de los ejemplos.

    //public class OrderLogic : BaseContextLogic IOrderLogic
    //{
    //    public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
    //    public void InsertOrderItem(OrderItem orderItem)
    //    {
    //        _serviceContext.Orders.Add(orderItem);
    //        _serviceContext.SaveChanges();
    //    }
    //}

    ////manera más simple, pero peor. está en la masterclass.
    //public class OrderLogic : IOrderLogic
    //{
    //    private readonly ServiceContext _serviceContext;
    //    public OrderLogic(ServiceContext serviceContext)
    //    {
    //        _serviceContext = serviceContext;
    //    }

    //    public void InsertOrderItem(OrderItem orderItem)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    //public void InsertOrderItem(OrderItem orderItem)
    //    //{
    //    //    _serviceContext.Orders.Add(orderItem);
    //    //    _serviceContext.SaveChanges();
    //    //}
    //}
}