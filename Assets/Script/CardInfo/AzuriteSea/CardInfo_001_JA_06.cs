using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_06 : CardInfo
{
    public CardInfo_001_JA_06()
    {
        this.cardNo = "001_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒIƒEƒ‹";
        this.cardName2 = "ŠC‘¯‚ÌŒ©’£‚è”Ô";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
