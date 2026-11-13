using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_07 : CardInfo
{
    public CardInfo_054_JA_07()
    {
        this.cardNo = "054_JA_07";
        this.inkCost = 10;
        this.availableInk = true;
        this.cardName1 = "テ・カァ";
        this.cardName2 = "始原の脅威";
        this.power = 12;
        this.toughness = 12;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.NicolaSaviori;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift7 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
