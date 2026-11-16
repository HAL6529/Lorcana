using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_058_JA_06 : CardInfo
{
    public CardInfo_058_JA_06()
    {
        this.cardNo = "058_JA_06";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ピーター・パン";
        this.cardName2 = "影の捕獲者";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
