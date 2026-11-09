using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_083_JA_02 : CardInfo
{
    public CardInfo_083_JA_02()
    {
        this.cardNo = "083_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉKÉXÉgÉì";
        this.cardName2 = "ÇΩÇ≠ÇÁÇ›ÇÃãÅç•é“";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
