using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_204_JA_14 : CardInfo
{
    public CardInfo_204_JA_14()
    {
        this.cardNo = "204_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "カーン産業";
        this.cardName2 = "グリーンウェイの名所";
        this.power = 2;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DouglasDeLaHoz;
        this.classList = new List<EnumController.Class> { EnumController.Class.HyperiaCity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Rare;
    }
}
