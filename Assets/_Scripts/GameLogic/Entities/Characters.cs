using System.Collections;
using System.Collections.Generic;
using cfg;
using UnityEngine;
using ZToolKit;

namespace RoundGame
{
    public class Characters : IEntities<Character, ResPack>
    {
        private readonly CharacterFactory mChaFactory = new CharacterFactory();

        public List<Character> Entities { get; set; }

        public void Init()
        {
            
        }

        public Character Spawn(ResPack data)
        {
            return mChaFactory.Create(data.PrefabName);
        }

        public void Clear()
        {
            foreach (var character in Entities)
            {
                Object.Destroy(character.gameObject);
            }
            
            Entities.Clear();
        }
    }

    public class CharacterFactory: IFactory<Character>
    {
        public Character Create()
        {
            throw new System.NotImplementedException();
        }

        public Character Create(string name)
        {
            var template = ResTool.Load<GameObject>(name).GetComponent<Character>();
            return Object.Instantiate(template);
        }
    }
}
