using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_02 : CardInfo
{
    public CardInfo_029_JA_02()
    {
        this.cardNo = "029_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ç≈å„ÇÃëŒåà";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
