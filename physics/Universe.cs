using System;
using System.Collections.Generic;
using Physics.Interfaces;
using Physics.Systems;

namespace Physics
{
    public class Universe
    {
        public SortedList<int, IEntity> entities = new SortedList<int, IEntity>();
        private Random _rand;
        public Infrastructure inf;

        public Universe() : this(new Random()){}  

        public Universe(Random rng)
        {
            _rand = rng;
            inf = new Infrastructure(this, _rand);
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