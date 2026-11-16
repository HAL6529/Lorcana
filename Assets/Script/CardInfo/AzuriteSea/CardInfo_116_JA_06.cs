using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_06 : CardInfo
{
    public CardInfo_116_JA_06()
    {
        this.cardNo = "116_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アドラビーズル・ウィンターポップ";
        this.cardName2 = "アイスロケット・レーサー";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
