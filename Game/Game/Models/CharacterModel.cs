﻿
namespace Game.Models
{
    public class CharacterModel : BasePlayerModel<CharacterModel>
    {
        public CharacterModel()
        {
            PlayerType = PlayerTypeEnum.Character;
            Guid = Id;
        }
    }
}