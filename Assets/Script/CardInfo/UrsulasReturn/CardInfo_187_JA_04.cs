using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_04 : CardInfo
{
    public CardInfo_187_JA_04()
    {
        this.cardNo = "187_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "いたずら好きな魔法使い";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
