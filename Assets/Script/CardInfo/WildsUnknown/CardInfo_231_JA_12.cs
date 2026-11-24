using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_231_JA_12 : CardInfo
{
    public CardInfo_231_JA_12()
    {
        this.cardNo = "231_JA_12";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "散り散りの家族";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Enchanted;
    }
}
