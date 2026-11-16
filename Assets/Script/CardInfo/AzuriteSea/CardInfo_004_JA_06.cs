using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_06 : CardInfo
{
    public CardInfo_004_JA_06()
    {
        this.cardNo = "004_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ゴーファー";
        this.cardName2 = "船大工";
        this.power = 1;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.WouterBruneel;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
