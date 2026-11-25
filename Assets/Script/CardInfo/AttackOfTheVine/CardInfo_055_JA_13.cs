using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_055_JA_13 : CardInfo
{
    public CardInfo_055_JA_13()
    {
        this.cardNo = "055_JA_13";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ヘラ";
        this.cardName2 = "ヴァインズの創造物";
        this.power = 4;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulianDelRey;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Queen, EnumController.Class.Deity, EnumController.Class.Vineling };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
