using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_03 : CardInfo
{
    public CardInfo_116_JA_03()
    {
        this.cardNo = "116_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "モアナ";
        this.cardName2 = "生まれついてのリーダー";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
