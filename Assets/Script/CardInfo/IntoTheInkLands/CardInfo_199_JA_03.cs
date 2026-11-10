using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_03 : CardInfo
{
    public CardInfo_199_JA_03()
    {
        this.cardNo = "199_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "フック船長のレイピア";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JeremyAdams;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
