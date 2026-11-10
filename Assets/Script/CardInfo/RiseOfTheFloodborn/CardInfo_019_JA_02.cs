using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_02 : CardInfo
{
    public CardInfo_019_JA_02()
    {
        this.cardNo = "019_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ラプンツェル";
        this.cardName2 = "天才アーティスト";
        this.power = 0;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
