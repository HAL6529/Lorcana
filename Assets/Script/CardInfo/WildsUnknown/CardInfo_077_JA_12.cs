using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_12 : CardInfo
{
    public CardInfo_077_JA_12()
    {
        this.cardNo = "077_JA_12";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "RC";
        this.cardName2 = "ラジコン・カー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
