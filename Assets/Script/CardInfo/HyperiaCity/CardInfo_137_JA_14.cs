using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_14 : CardInfo
{
    public CardInfo_137_JA_14()
    {
        this.cardNo = "137_JA_14";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "カール･フレドリクセン";
        this.cardName2 = "野外ガイド";
        this.power = 5;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.McKayAndersonAndTheonidas;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
