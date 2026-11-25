using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_13 : CardInfo
{
    public CardInfo_061_JA_13()
    {
        this.cardNo = "061_JA_13";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "クリストファー・ロビン";
        this.cardName2 = "はちみつの賢者";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
