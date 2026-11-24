using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_12 : CardInfo
{
    public CardInfo_180_JA_12()
    {
        this.cardNo = "180_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マッキントッシュの若君";
        this.cardName2 = "イキリ息子";
        this.power = 4;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
