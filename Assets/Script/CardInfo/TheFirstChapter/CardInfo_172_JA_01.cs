using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_01 : CardInfo
{
    public CardInfo_172_JA_01()
    {
        this.cardNo = "172_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "èùêSÇÃäÊå≈é“";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Cookie";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
