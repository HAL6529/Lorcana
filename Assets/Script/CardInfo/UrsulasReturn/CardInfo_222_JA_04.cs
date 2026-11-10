using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_222_JA_04 : CardInfo
{
    public CardInfo_222_JA_04()
    {
        this.cardNo = "222_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "èÈï«";
        this.cardName2 = "çëã´ÇÃóvç«";
        this.power = 2;
        this.toughness = 8;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.AndreasRocha;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Enchanted;
    }
}
