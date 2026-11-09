using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_02 : CardInfo
{
    public CardInfo_073_JA_02()
    {
        this.cardNo = "073_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "バッキー";
        this.cardName2 = "リス語の先生";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexAccorsi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
