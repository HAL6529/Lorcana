using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_14 : CardInfo
{
    public CardInfo_174_JA_14()
    {
        this.cardNo = "174_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "予測不能な配達屋さん";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
