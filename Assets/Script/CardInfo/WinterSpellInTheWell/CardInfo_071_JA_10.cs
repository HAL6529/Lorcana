using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_10 : CardInfo
{
    public CardInfo_071_JA_10()
    {
        this.cardNo = "071_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フロットサム";
        this.cardName2 = "ぬらりくらりのウツボ";
        this.power = 4;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RicardoCaria;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
