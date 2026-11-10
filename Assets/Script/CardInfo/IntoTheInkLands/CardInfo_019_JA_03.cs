using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_03 : CardInfo
{
    public CardInfo_019_JA_03()
    {
        this.cardNo = "019_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒ|ƒ“ƒS";
        this.cardName2 = "ŒˆˆÓ‚Ì•ƒŒ¢";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
