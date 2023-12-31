using UnityEngine;

namespace FireSpreading
{
    public abstract class MouseMode : IRepresentative
    {
        protected string _name; //Inheritors require constructor with name initialization

        public string GetName() { return _name; }
        public abstract void Interact(GameObject pointedObject, InteractionSystem interactionSystem);
    }
}