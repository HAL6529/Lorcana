using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_041_JA_14 : CardInfo
{
    public CardInfo_041_JA_14()
    {
        this.cardNo = "041_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "アルキメデス";
        this.cardName2 = "これが吾輩の逃走ホーホー";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulesDubost;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
