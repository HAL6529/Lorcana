using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_10 : CardInfo
{
    public CardInfo_174_JA_10()
    {
        this.cardNo = "174_JA_10";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "首なし騎士";
        this.cardName2 = "呪われた乗り手";
        this.power = 5;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheAdventuresOfIchabodAndMrToad;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
