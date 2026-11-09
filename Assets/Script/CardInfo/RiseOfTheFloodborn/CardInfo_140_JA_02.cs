using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_02 : CardInfo
{
    public CardInfo_140_JA_02()
    {
        this.cardNo = "140_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒoƒWƒ‹";
        this.cardName2 = "‰s‚¢Ž„—§’T’ã";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RogerPerez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
