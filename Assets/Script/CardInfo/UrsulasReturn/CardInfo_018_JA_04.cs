using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_04 : CardInfo
{
    public CardInfo_018_JA_04()
    {
        this.cardNo = "018_JA_04";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ミラベル・マドリガル";
        this.cardName2 = "家族のギフト";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
