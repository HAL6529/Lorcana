using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_13 : CardInfo
{
    public CardInfo_005_JA_13()
    {
        this.cardNo = "005_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラビット";
        this.cardName2 = "はちみつのパラディン";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Knight, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
