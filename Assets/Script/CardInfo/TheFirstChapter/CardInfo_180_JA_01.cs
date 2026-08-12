using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_01 : CardInfo
{
    public CardInfo_180_JA_01()
    {
        this.cardNo = "180_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉnÉìÉX";
        this.cardName2 = "â§à åpè≥å†ëÊ13à ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Kendall Hale";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
