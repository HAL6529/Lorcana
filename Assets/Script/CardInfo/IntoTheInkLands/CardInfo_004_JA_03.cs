using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_03 : CardInfo
{
    public CardInfo_004_JA_03()
    {
        this.cardNo = "004_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ダルメシアンの子犬";
        this.cardName2 = "しっぽフリフリちゃん";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
