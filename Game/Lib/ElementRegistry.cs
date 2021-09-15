using System;
using System.Collections.Generic;
using TBRPG_1.Game.Elements;

namespace TBRPG_1.Game.Lib
{
    public class ElementRegistry
    {
        public Dictionary<string, object> ElementMap { get; set; } = new();

        public Dictionary<string, List<string>> ChildMap { get; set; } = new();
        
        public void Register(IIdentity parent, IIdentity self)
        {
            Console.WriteLine((self as SourceElement)?.Tag);
            if (parent is not null)
            {
                if (ChildMap.TryAdd(parent.UUID, new List<string>()))
                {
                    ChildMap[parent.UUID].Add(self.UUID);
                }
            }
            ElementMap.Add(self.UUID, self);
        }
    }
}