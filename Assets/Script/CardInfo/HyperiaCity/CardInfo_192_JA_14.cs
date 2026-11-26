using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_14 : CardInfo
{
    public CardInfo_192_JA_14()
    {
        this.cardNo = "192_JA_14";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "一発必中の飛行士";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SandraRios;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
