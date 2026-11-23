using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_11 : CardInfo
{
    public CardInfo_136_JA_11()
    {
        this.cardNo = "136_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "野獣の城";
        this.cardName2 = "冬の庭園";
        this.power = 1;
        this.toughness = 6;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.GeoffreyBoudout;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
