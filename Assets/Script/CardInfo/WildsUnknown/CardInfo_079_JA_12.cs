using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_12 : CardInfo
{
    public CardInfo_079_JA_12()
    {
        this.cardNo = "079_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レニー";
        this.cardName2 = "おもちゃの双眼鏡";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
