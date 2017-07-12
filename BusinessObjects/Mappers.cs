﻿using System;
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

            return result;
        }
    }
}
