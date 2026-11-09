using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_197_JA_02 : CardInfo
{
    public CardInfo_197_JA_02()
    {
        this.cardNo = "197_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ティアナ";
        this.cardName2 = "勤勉なウェイトレス";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
