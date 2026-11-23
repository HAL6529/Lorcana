using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_177_JA_11 : CardInfo
{
    public CardInfo_177_JA_11()
    {
        this.cardNo = "177_JA_11";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ランチパッド";
        this.cardName2 = "頼もしい相棒";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
