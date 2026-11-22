using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_10 : CardInfo
{
    public CardInfo_083_JA_10()
    {
        this.cardNo = "083_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ランチパッド";
        this.cardName2 = "スゴ腕パイロット";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AristeidisZentelis;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
