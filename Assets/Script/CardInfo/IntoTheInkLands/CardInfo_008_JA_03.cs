using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_03 : CardInfo
{
    public CardInfo_008_JA_03()
    {
        this.cardNo = "008_JA_03";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ラッキー";
        this.cardName2 = "15番目の子犬";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
