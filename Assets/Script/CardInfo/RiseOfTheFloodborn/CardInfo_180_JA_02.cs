using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_02 : CardInfo
{
    public CardInfo_180_JA_02()
    {
        this.cardNo = "180_JA_02";
        this.inkCost = 9;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "一日騎士";
        this.power = 10;
        this.toughness = 10;
        this.lore = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.MarcoGiorgianni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
