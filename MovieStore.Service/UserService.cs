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
    public class UserService : BaseService, IService<UserDTO>
    {
        public UserDTO Add(UserDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    obj.UserName = string.Format("{0}.{1}", obj.FirstName.ToLower(), obj.LastName.ToLower());
                    obj.Password = new Random().Next(1235, 9945).ToString();
                    obj.RecordStatusId = 1;
                    obj.CreatedDate = DateTime.Now;
                    obj.LastLoginDate = DateTime.Now;

                    var user = uow.Users.Add(Mapper.Map<UserDTO, User>(obj));
                    uow.Commit();

                    return Mapper.Map<User, UserDTO>(user);
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return null;
                }
            }
        }

        public UserDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Users.Get(id);
                    var user = Mapper.Map<User, UserDTO>(entity);
                    user.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    user.CreatedByName = entity.User1.FirstName + entity.User1.LastName;
                    return user;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<UserDTO> List()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entities = uow.Users.List();

                    List<UserDTO> list = new List<UserDTO>();

                    foreach (var item in entities)
                    {
                        var user = Mapper.Map<User, UserDTO>(item);
                        user.RecordStatusName = item.RecordStatus.RecordStatusName;

                        list.Add(user);
                    }

                    return list;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public bool Update(UserDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<UserDTO, User>(obj);
                    uow.Users.Update(entity);
                    uow.Commit();
                    return true;

                }
                catch (Exception ex)
                {

                    uow.RollBack();
                    return false;
                }
            }
        }
    }
}
