using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_03 : CardInfo
{
    public CardInfo_014_JA_03()
    {
        this.cardNo = "014_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "パッチ";
        this.cardName2 = "威嚇する子犬";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
