using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class ProjectMapper
    {
        public static Project ToEntity(ProjectDto dto)
        {
            return new Project
            {
                Title = dto.Title,
                Description = dto.Description
            };
        }

        public static ProjectDto ToDto(Project entity)
        {
            return new ProjectDto
            {
                Title = entity.Title,
                Description = entity.Description
            };
        }
    }
}
