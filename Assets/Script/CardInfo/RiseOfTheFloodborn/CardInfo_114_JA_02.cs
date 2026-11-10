using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_02 : CardInfo
{
    public CardInfo_114_JA_02()
    {
        this.cardNo = "114_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミニーマウス";
        this.cardName2 = "びっくりダイバー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AdamFenton;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift2, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
