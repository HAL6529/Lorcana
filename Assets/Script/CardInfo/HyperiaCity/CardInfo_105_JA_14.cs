using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_14 : CardInfo
{
    public CardInfo_105_JA_14()
    {
        this.cardNo = "105_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "ダンシング・スーパースター";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Singer6 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
