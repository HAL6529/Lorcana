using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_032_JA_02 : CardInfo
{
    public CardInfo_032_JA_02()
    {
        this.cardNo = "032_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ZERO TO HERO";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RobDiSalvo;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
