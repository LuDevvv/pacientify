//using Pacientify.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Pacientify.Infrastructure.Persistence.Repositories
//{
//    public class UserRepository
//    {
//        private readonly DbContext _context;

//        public UserRepository(DbContext context)
//        {
//            _context = context;
//        }

//        public List<User> GetAllUsers()
//        {
//            return _context.Users.ToList();
//        }

//        public User GetUserById(int userId)
//        {
//            return _context.Users.FirstOrDefault(u => u.Id == userId);
//        }

//        public void AddUser(User user)
//        {
//            _context.Users.Add(user);
//            _context.SaveChanges();
//        }

//        public void UpdateUser(User user)
//        {
//            _context.Entry(user).State = EntityState.Modified;
//            _context.SaveChanges();
//        }

//        public void DeleteUser(int userId)
//        {
//            var user = _context.Users.FirstOrDefault(u => u.Id == userId);
//            if (user != null)
//            {
//                _context.Users.Remove(user);
//                _context.SaveChanges();
//            }
//        }
//    }
//}
