using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_06 : CardInfo
{
    public CardInfo_047_JA_06()
    {
        this.cardNo = "047_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "スカー";
        this.cardName2 = "狂嵐のライオン";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.PeterBrockhammer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
