using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_13 : CardInfo
{
    public CardInfo_078_JA_13()
    {
        this.cardNo = "078_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ゴーファー";
        this.cardName2 = "はちみつの料理人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FrenchCarlomagno;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
