using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_06 : CardInfo
{
    public CardInfo_022_JA_06()
    {
        this.cardNo = "022_JA_06";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ラビット";
        this.cardName2 = "ムスっとした海賊";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Samoldstoree;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
