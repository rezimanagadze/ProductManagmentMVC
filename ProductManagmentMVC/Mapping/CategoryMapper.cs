using ProductManagmentMVC.Interfaces;
using ProductManagmentMVC.Models;

namespace ProductManagmentMVC.Mapping
{
    public class CategoryMapper: IMapper<Entity.Category, CategoryModel>
    {
        public CategoryModel MapFromEntityToModel(Entity.Category source) => new CategoryModel
        {
            Name = source.Name,
            Description = source.Description,
            Code = source.Code,
            Id = source.Id,
        };
    
        public Entity.Category MapFromModelToEntity(CategoryModel source)
        {
            var entity = new Entity.Category();

            MapFromModelToEntity(source, entity);

            return entity;
        }

        public void MapFromModelToEntity(CategoryModel source, Entity.Category target)
        {
            target.Name = source.Name;
            target.Description = source.Description;
            target.Code = source.Code;
            target.Id = source.Id;
        }

    }
}
