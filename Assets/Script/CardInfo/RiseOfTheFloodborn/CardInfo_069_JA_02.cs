using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_02 : CardInfo
{
    public CardInfo_069_JA_02()
    {
        this.cardNo = "069_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アーサー";
        this.cardName2 = "修業を積んだ剣士";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioOscarGabriele;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
