using Physics.Components;
using Physics.Interfaces;
using Physics.Models;

namespace Physics.Systems
{
    public class Collision : ISystem
    {
        private Universe _unv;

        public Collision(Universe unv)
        {
            _unv = unv;
        }
        
        public Universe GetUniverse() => _unv;
    }
}