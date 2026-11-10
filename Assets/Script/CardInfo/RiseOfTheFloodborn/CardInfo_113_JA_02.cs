using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_02 : CardInfo
{
    public CardInfo_113_JA_02()
    {
        this.cardNo = "113_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "シックなサーファー";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
