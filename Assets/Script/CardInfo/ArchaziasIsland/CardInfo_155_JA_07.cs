using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_07 : CardInfo
{
    public CardInfo_155_JA_07()
    {
        this.cardNo = "155_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マティアス";
        this.cardName2 = "アレンデールの将軍";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Knight };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
