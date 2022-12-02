using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using MyDataStructures;

namespace BussinessLayer
{
    //identity map is implemented as simple dictionary
    public class IdentityMap
    {
        public Dictionary<int, Actor> pool = new Dictionary<int, Actor>();

        public void AddItem(int id, Actor actor)
        {
            if (!pool.ContainsKey(id))
            {
                pool.Add(id, actor);
                return;
            }

            pool[id] = actor;
        }

        public bool RemoveItem(int id)
        {
            if (!pool.ContainsKey(id))
                return false;

            return pool.Remove(id);
        }

        public Actor GetItem(int id)
        {
            if (!pool.ContainsKey(id))
            {
                ActorGateway gateway = new ActorGateway();
                Actor a = gateway.FindActor(id);
                AddItem(a.actor_id, a);
            }
            return pool[id];
        }
    }
}
