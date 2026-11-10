using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_021_JA_03 : CardInfo
{
    public CardInfo_021_JA_03()
    {
        this.cardNo = "021_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ローリー";
        this.cardName2 = "腹ペコの子犬";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DefneTozumAndDennyMinonne;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Puppy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
