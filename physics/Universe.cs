using System.Collections.Generic;
using Physics.Interfaces;
using Physics.Systems;

namespace Physics
{
    public class Universe
    {
        public SortedList<int, IEntity> entities = new SortedList<int, IEntity>();
        public Infrastructure inf;

        public Universe()
        {
            inf = new Infrastructure(this);
        }

        public int LastEntityId()
        {
            if(entities.Count == 0) return 0;

            return entities.Max().Key;
        }        

        public Entity GetEntity()
        {
            var ef = new EntityFactory();
            var entity = ef.GetEntity(LastEntityId());
            entities.Add(entity.Id, entity);
            return entity;
        }
    }
}