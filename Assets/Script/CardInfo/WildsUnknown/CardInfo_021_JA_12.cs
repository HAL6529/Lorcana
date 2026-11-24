using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_12 : CardInfo
{
    public CardInfo_021_JA_12()
    {
        this.cardNo = "021_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ウッディ";
        this.cardName2 = "おもちゃのリーダー";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
