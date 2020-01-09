using System;
using System.Collections.Generic;
using System.Linq;
using EC.Components;
using EC.CoreEC;
using IComponent = System.ComponentModel.IComponent;

namespace EC
{
    class MainClass
    {

        EntitiesPool _context =  new EntitiesPool();
        private static int _countEntity = 2;
        
        
        void Main()
        {
            CreateEntitySilencer(_context);
            CreateEntityRearSight(_context);
            CreateEntitiesGuns(_context);
            CreateEntityInventory(_context);
            CreateEntityPlayer(_context);
        }

        void CreateEntitySilencer(EntitiesPool pool)
        {
            var silencerComponent = new Silencer();
            pool.CreateEntityAndAddComponent(silencerComponent, _countEntity);
        }
        
        void CreateEntityRearSight(EntitiesPool pool)
        {
            var realSightComponent = new RearSight();
            pool.CreateEntityAndAddComponent(realSightComponent, _countEntity);
        }

        void CreateEntitiesGuns(EntitiesPool pool)
        {
            var gunEntity = _context.CreateEntity();
            gunEntity.AddComponent(new Gun());
            gunEntity.AddComponent(new ComponentLinkToSilencer(){ LinkToEntity = _context.Find(PoolMatcher.Silencer).First()});
            gunEntity.AddComponent(new ComponentLinkToRearSight(){ LinkToEntity = _context.Find(PoolMatcher.RealSight).First()});
            
            //почти аналогичный код для второго оружия
        }

        void CreateEntityInventory(EntitiesPool pool)
        {
            var inventoryEntity = _context.CreateEntity();
            var allGuns = pool.Find(PoolMatcher.Guns);
            inventoryEntity.AddComponent(new Inventory());
            inventoryEntity.AddComponent(new EntityLinkComponent(){ LinksToEntity = new List<Entity>(allGuns)});
        }

        void CreateEntityPlayer(EntitiesPool pool)
        {
            var playerEntity = _context.CreateEntity();
            playerEntity.AddComponent(new Player());
            playerEntity.AddComponent(new EntityLinkComponent() { LinkToEntity = _context.Find(PoolMatcher.Inventory).First()});
        }


        void Mount()
        {
               
        }


        void Dismount()
        {
            
        }
    }
}