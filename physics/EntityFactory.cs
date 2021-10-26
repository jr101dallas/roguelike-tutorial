namespace physics
{
    public class EntityFactory
    {
        public Entity GetEntity(int lastEntityId)
        {
            return new Entity(){
                Id = ++lastEntityId
            };
        }
    }
}