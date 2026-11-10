using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_02 : CardInfo
{
    public CardInfo_156_JA_02()
    {
        this.cardNo = "156_JA_02";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "オウル";
        this.cardName2 = "論理的な論客";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
