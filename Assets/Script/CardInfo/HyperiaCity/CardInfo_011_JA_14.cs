using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_14 : CardInfo
{
    public CardInfo_011_JA_14()
    {
        this.cardNo = "011_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ニック・ワイルド";
        this.cardName2 = "鋭い目の港湾局長";
        this.power = 3;
        this.toughness = 5;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.GianlucaBarone;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
