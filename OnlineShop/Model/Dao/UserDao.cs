using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace Model.Dao
{
    public class UserDao
    {
        ShopOnlineDBContext db = null;
        public UserDao()
        {
            db = new ShopOnlineDBContext();
        }

        public IEnumerable<User> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<User> model = db.Users;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.UserName.Contains(searchString) || x.Name.Contains(searchString));
            }
            //Viet them cau dk if neu muon tim kiem theo truong khac
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }

        public bool FindUserName(User entity)
        {
            var listUser = db.Users;
            bool check = false;
            foreach (var item in listUser)
            {
                if (entity.UserName == item.UserName)
                {
                    check = true;
                }
            }
            return check;
        }

        public long Insert(User entity)
        {
            bool check = FindUserName(entity); 
            if (check == false)
            {
                db.Users.Add(entity);
                db.SaveChanges();
                return entity.ID;
            }
            else
            {
                return -1;
            }                      
        }

        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Password = entity.Password;
                if (!string.IsNullOrEmpty(user.Password))
                {
                    user.Name = entity.Name;
                }               
                user.Address = entity.Address;
                user.Email = entity.Email;
                user.Phone = entity.Phone;
                user.ModifyBy = entity.ModifyBy;
                user.ModifyDate = DateTime.Now;
                user.Status = entity.Status;
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }           
        }

        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        public User ViewDetail(long id)
        {
            return db.Users.Find(id);
        }

        public int Login(string userName, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if(result == null)
            {
                return 0;
            }
            else 
            {
                if(result.Status == false)
                {
                    return -1;
                }
                else 
                {
                    if (result.Password == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }   
                }
            }
        }

    }
}
