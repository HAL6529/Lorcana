using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_06 : CardInfo
{
    public CardInfo_038_JA_06()
    {
        this.cardNo = "038_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジーニー";
        this.cardName2 = "ゴキゲンな造船マン";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
