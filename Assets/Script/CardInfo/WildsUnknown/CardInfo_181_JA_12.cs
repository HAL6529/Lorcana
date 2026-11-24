using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_12 : CardInfo
{
    public CardInfo_181_JA_12()
    {
        this.cardNo = "181_JA_12";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "マッキントッシュ卿";
        this.cardName2 = "カミナリ親父";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
