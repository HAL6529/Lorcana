using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_04 : CardInfo
{
    public CardInfo_005_JA_04()
    {
        this.cardNo = "005_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "コグスワース";
        this.cardName2 = "執事長";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
