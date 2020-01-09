using System.Collections.Generic;
using EC.CoreEC;

namespace EC.Components
{
    /// <summary>
    /// Весь код писался ради этого решения. 
    /// </summary>
    public class EntityLinkComponent : IComponent
    {
        
        public Entity LinkToEntity;
        public List<Entity> LinksToEntity = new List<Entity>();
    }
}