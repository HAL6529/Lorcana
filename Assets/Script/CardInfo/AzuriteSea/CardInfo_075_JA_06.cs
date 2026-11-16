using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_06 : CardInfo
{
    public CardInfo_075_JA_06()
    {
        this.cardNo = "075_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "フレッド";
        this.cardName2 = "昼はスクールマスコット";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendellAndDaniellePowers;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
