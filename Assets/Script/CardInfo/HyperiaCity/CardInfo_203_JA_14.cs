using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_203_JA_14 : CardInfo
{
    public CardInfo_203_JA_14()
    {
        this.cardNo = "203_JA_14";
        this.inkCost =14;
        this.availableInk = true;
        this.cardName1 = "中央駅";
        this.cardName2 = "交通ハブ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.EtienneSavoie;
        this.classList = new List<EnumController.Class> { EnumController.Class.HyperiaCity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Common;
    }
}
