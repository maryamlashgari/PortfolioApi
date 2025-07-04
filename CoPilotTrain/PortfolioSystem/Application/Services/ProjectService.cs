using Application.DTOs;
using Application.Interfaces;
using Application.Mappers;

namespace Application.Services
{
    public class ProjectService : IProjectService
    {
        public readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task CreateAsync(ProjectDto dto)
        {
            await _projectRepository.AddAsync(ProjectMapper.ToEntity(dto));
        }
    }
}