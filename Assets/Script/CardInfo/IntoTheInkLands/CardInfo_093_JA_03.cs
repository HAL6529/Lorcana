using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_093_JA_03 : CardInfo
{
    public CardInfo_093_JA_03()
    {
        this.cardNo = "093_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ザズー";
        this.cardName2 = "プライドランドの執事";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
