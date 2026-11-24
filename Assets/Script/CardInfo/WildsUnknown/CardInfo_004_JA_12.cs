using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_12 : CardInfo
{
    public CardInfo_004_JA_12()
    {
        this.cardNo = "004_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デール";
        this.cardName2 = "ウッキウキの友";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlineBeserman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
