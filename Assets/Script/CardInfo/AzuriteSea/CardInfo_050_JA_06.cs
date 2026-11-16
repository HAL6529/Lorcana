using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_06 : CardInfo
{
    public CardInfo_050_JA_06()
    {
        this.cardNo = "050_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "éOåéÇ§Ç≥Ç¨";
        this.cardName2 = "ÉwÉìÉeÉRÇ»éÂç√é“";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JamesReySanchez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
