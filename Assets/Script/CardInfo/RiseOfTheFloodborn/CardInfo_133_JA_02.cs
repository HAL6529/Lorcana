using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_133_JA_02 : CardInfo
{
    public CardInfo_133_JA_02()
    {
        this.cardNo = "133_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "YOU CAN FLY";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Uncommon;
    }
}
