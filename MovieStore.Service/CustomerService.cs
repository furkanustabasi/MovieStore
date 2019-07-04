using MovieStore.Data;
using MovieStore.Data.UnitOfWork;
using MovieStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Service
{
    public class CustomerService : BaseService, IService<CustomerDTO>
    {
        public CustomerDTO Add(CustomerDTO obj)
        {
            using (UnitOfWork uow=new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<CustomerDTO, Customer>(obj);
                    entity.RecordStatusId = 1;
                    entity.CreatedDate = DateTime.Now;
                    var customer = uow.Customers.Add(entity);
                    uow.Commit();

                    return Mapper.Map<Customer, CustomerDTO>(customer);
                }
                catch (Exception ex)
                {

                    uow.RollBack();
                    return null;
                }
            }
        }

        public CustomerDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Customers.Get(id);
                    var customer = Mapper.Map<Customer, CustomerDTO>(entity);
                    customer.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    return customer;

                }
                catch (Exception)
                {

                    return null;
                }

            }
        }

        public List<CustomerDTO> List()
        {
            using (UnitOfWork uow=new UnitOfWork())
            {
                try
                {
                    var entities = uow.Customers.List();
                    List<CustomerDTO> list = new List<CustomerDTO>();
                    foreach (var item in entities)
                    {
                        list.Add(Mapper.Map<Customer, CustomerDTO>(item));

                    }
                    return list;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public bool Update(CustomerDTO obj)
        {
            using (UnitOfWork uow=new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<CustomerDTO, Customer>(obj);
                    uow.Customers.Update(entity);
                    uow.Commit();
                    return true;
                }
                catch (Exception)
                {

                    uow.RollBack();
                    return false;
                }
            }
        }
    }
}
