using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_202_JA_02 : CardInfo
{
    public CardInfo_202_JA_02()
    {
        this.cardNo = "202_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "‚Æ‚Á‚Ä‚¨‚«‚Ì‘å–C";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.JaredNickerl;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Common;
    }
}
