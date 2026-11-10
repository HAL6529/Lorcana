using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_03 : CardInfo
{
    public CardInfo_033_JA_03()
    {
        this.cardNo = "033_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "プライドランド";
        this.cardName2 = "プライドロック";
        this.power = 2;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BeverlyArceAndJonathanLivslyst;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
