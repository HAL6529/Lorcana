using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_06 : CardInfo
{
    public CardInfo_085_JA_06()
    {
        this.cardNo = "085_JA_06";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "ネバーランドのイタズラ小僧";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
