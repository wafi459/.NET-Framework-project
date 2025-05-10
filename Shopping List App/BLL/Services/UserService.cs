using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<UserLoginDTO, User>();
            });
            return new Mapper(config);
        }

        public static UserDTO Register(UserDTO user)
        {
            var repo = DataAccessFactory.UserData();

          
            var userEntity = GetMapper().Map<User>(user);

            var createdUser = repo.Add(userEntity);

           
            return GetMapper().Map<UserDTO>(createdUser);
        }

        public static UserDTO Login(UserLoginDTO loginDTO)
        {
            var repo = DataAccessFactory.UserData();

           
            var user = repo.GetByUsername(loginDTO.Username);

            
            return GetMapper().Map<UserDTO>(user);
        }
    }
}
