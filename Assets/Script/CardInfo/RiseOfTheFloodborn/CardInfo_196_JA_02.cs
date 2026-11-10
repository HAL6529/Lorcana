using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_196_JA_02 : CardInfo
{
    public CardInfo_196_JA_02()
    {
        this.cardNo = "196_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ティアナ";
        this.cardName2 = "祝福のプリンセス";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
