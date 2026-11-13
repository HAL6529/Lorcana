using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_048_JA_07 : CardInfo
{
    public CardInfo_048_JA_07()
    {
        this.cardNo = "048_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハニーマレン";
        this.cardName2 = "ノーサルドラの案内人";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
