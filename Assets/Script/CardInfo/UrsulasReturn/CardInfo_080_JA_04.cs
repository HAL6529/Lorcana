using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_04 : CardInfo
{
    public CardInfo_080_JA_04()
    {
        this.cardNo = "080_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉÅÉO";
        this.cardName2 = "ëfíºÇ…Ç»ÇÍÇΩ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.YeYangAndRaquelVillanueva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
