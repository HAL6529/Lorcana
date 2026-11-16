using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_06 : CardInfo
{
    public CardInfo_114_JA_06()
    {
        this.cardNo = "114_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "アブー";
        this.cardName2 = "度胸満点の舵取り";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.OggysonArt;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
