using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_06 : CardInfo
{
    public CardInfo_171_JA_06()
    {
        this.cardNo = "171_JA_06";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "カカモラ";
        this.cardName2 = "吹き矢の達人";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
