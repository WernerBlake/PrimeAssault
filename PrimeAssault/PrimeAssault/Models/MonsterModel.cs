﻿namespace PrimeAssault.Models
{
    /// <summary>
    /// The Monsters in the PrimeAssault
    /// 
    /// Derives from BasePlayer Model just like Character
    /// </summary>
    public class MonsterModel : BasePlayerModel<MonsterModel>
    {
        /// <summary>
        /// Set Type to Monster
        /// 
        /// Set Name and Description
        /// </summary>
        public MonsterModel()
        {
            PlayerType = PlayerTypeEnum.Monster;
            Guid = Id;
            Name = "Troll";
            Description = "Angry Troll";
            Attack = 100;
        }
    }
}