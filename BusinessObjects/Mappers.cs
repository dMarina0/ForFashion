using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public static class Mappers
    {
        public static ShirtDto ToShirtDto(Shirt shirt)
        {
            var result = new ShirtDto();
            result.Id = shirt.Id;
            result.Name = shirt.Name;
            return result;
        }

        public static IEnumerable<ShirtDto> ToShirtDtos(this IEnumerable<Shirt> shirts)
        {
            var result = shirts.Select(it => new ShirtDto()
            {
                Id = it.Id,
                Name = it.Name
            });
            shirts.Take(3);
            return result;
        }
        public static DressDto ToDressDto(Dress dress)
        {
            var result = new DressDto();
            result.Id = dress.Id;
            result.Name = dress.Name;
            return result;
        }
        public static Dress ToDressEntity(DressDto dressDto)
        {
            var result = new Dress();
            result.Id = dressDto.Id;
            result.Name = dressDto.Name;
            return result;
        }
        public static IEnumerable<DressDto> ToDressDtos(this IEnumerable<Dress> dress)
        {
            var result = dress.Select(it => new DressDto()
            {
                Id = it.Id,
                Name = it.Name
                
            });
            return result;
        }
        public static IEnumerable<FashionHouseDto> ToFashionHouseDtos(this IEnumerable<FashionHouse> FashionHouse)
        {
            var result = FashionHouse.Select(it => new FashionHouseDto()
            {
                Id = it.Id,
                Name = it.Name,
                PhoneNumber = it.PhoneNumber

            });
            
            return result;
        }

        public static FashionHouseDto ToFashionHouseDto(this FashionHouse fashionHouse)
        {
            var result = new FashionHouseDto()
            {
                Id = fashionHouse.Id,
                Name = fashionHouse.Name,
                PhoneNumber = fashionHouse.PhoneNumber
            };

            return result;
        }

        public static IEnumerable<CollectionDto> ToCollectionDtos(this IEnumerable<Collection> collection)
        {
            var result = collection.Select(it => new CollectionDto()
            {
                Id = it.Id,
                Name = it.Name,
                year = it.year,
               //FashionHouse = it.FashionHouse
            });
            //collection.Take(3);
            return result;
        }
        public static CollectionDto ToCollectionDto(this Collection collection)
        {
            var result = new CollectionDto()
            {
                Id = collection.Id,
                Name = collection.Name,
                year = collection.year,
                //FashionHouse = it.FashionHouse
            };
            //collection.Take(3);
            return result;
        }

        public static IEnumerable<VideosDto> ToVideosDtos(this IEnumerable<Videos> Videos)
        {
            var result = Videos.Select(it => new VideosDto()
            {
                Id = it.Id,
                VideoUrl = it.VideoUrl,
            });
            return result;
        }
    }
}
