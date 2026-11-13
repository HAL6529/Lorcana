using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_078_JA_07 : CardInfo
{
    public CardInfo_078_JA_07()
    {
        this.cardNo = "078_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ドロレス・マドリガル";
        this.cardName2 = "耳と島";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
