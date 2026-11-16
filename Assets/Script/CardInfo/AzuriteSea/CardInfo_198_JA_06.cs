using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_198_JA_06 : CardInfo
{
    public CardInfo_198_JA_06()
    {
        this.cardNo = "198_JA_06";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "Ç”Ç¢Ç§ÇøÅIÅI";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.IlariaSposetti;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Rare;
    }
}
