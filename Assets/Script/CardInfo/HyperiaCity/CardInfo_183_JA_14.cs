using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_14 : CardInfo
{
    public CardInfo_183_JA_14()
    {
        this.cardNo = "183_JA_14";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ボゴ署長";
        this.cardName2 = "警察本部長";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.VeronicaDiLorenzoAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
