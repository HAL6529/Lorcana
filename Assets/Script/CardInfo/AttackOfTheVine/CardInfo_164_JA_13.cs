using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_164_JA_13 : CardInfo
{
    public CardInfo_164_JA_13()
    {
        this.cardNo = "164_JA_13";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "イーヨー";
        this.cardName2 = "はちみつの学者";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
