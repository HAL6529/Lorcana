using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_14 : CardInfo
{
    public CardInfo_034_JA_14()
    {
        this.cardNo = "034_JA_14";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "港務局";
        this.cardName2 = "中央ハブ";
        this.power = 1;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class> { EnumController.Class.HyperiaCity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Lorcana;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
