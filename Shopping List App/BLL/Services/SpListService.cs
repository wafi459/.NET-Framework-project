using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SpListService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<ItemDTO, Item>();
            });
            return new Mapper(config);
        }

        public static ItemDTO Add(ItemDTO item)
        {
            var repo = DataAccessFactory.ListData();

            var itemEntity = GetMapper().Map<Item>(item);

         
            var create = repo.Add(itemEntity);

            
            return GetMapper().Map<ItemDTO>(create);
        }

        public static List<ItemDTO> GetItems()
        {
            var repo = DataAccessFactory.ListData();

            var items = repo.GetAll();
            return GetMapper().Map<List<ItemDTO>>(items);
        }

        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.ListData();

            return repo.Delete(id);
        }
    }
}
