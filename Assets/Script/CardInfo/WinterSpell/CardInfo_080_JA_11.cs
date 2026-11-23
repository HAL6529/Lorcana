using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_080_JA_11 : CardInfo
{
    public CardInfo_080_JA_11()
    {
        this.cardNo = "080_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スクイークス";
        this.cardName2 = "ぽかぽかイモムシ";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.YuNguyen;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
