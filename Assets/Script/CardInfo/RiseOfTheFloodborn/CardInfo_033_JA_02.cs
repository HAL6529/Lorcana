using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_02 : CardInfo
{
    public CardInfo_033_JA_02()
    {
        this.cardNo = "033_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ó¥ÇÃêŒ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AndrewTrabbold;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Rare;
    }
}
