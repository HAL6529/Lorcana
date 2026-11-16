using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_06 : CardInfo
{
    public CardInfo_041_JA_06()
    {
        this.cardNo = "041_JA_06";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジュジュ";
        this.cardName2 = "ママ・オーディの相棒";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevez;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
