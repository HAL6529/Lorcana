using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_06 : CardInfo
{
    public CardInfo_090_JA_06()
    {
        this.cardNo = "090_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ベルウェザー";
        this.cardName2 = "副市長";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Samoldstoree;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
