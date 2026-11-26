using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_184_JA_14 : CardInfo
{
    public CardInfo_184_JA_14()
    {
        this.cardNo = "184_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ペリノー卿";
        this.cardName2 = "見かけによらずタフ";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JosepSole;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
