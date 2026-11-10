using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_04 : CardInfo
{
    public CardInfo_155_JA_04()
    {
        this.cardNo = "155_JA_04";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉVÉXÅ[";
        this.cardName2 = "å´Ç´óF";
        this.power = 6;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RogerPerezAndHayleyEvans;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity, EnumController.Class.Dragon };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
