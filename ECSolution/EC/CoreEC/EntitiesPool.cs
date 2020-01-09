using System.Threading;
using EC.CoreEC;

namespace EC
{
    public class EntitiesPool
    {
        public Entity[] Find(PoolMatcher matcher)
        {
            return null;
        }
        
        
        public Entity CreateEntityAndAddComponent(IComponent component)
        {
            return null;
        }
        
        public Entity CreateEntityAndAddComponent(IComponent[] component, int countEntity)
        {
            return null;
        }
        
        public Entity CreateEntity()
        {
            return null;
        }

        
        public Entity CreateEntityAndAddComponent(IComponent component, int countEntity)
        {
            return null;
        }
    }


    public enum PoolMatcher
    {
        Guns,
        Player,
        Item,
        Silencer,
        RealSight,
        Inventory
    }
}