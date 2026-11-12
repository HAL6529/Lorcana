using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_025_JA_07 : CardInfo
{
    public CardInfo_025_JA_07()
    {
        this.cardNo = "025_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "イサベラ・マドリガル";
        this.cardName2 = "この道こそ私なの";
        this.power = 3;
        this.toughness = 3;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
