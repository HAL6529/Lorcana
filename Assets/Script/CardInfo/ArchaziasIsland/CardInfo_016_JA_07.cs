using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_07 : CardInfo
{
    public CardInfo_016_JA_07()
    {
        this.cardNo = "016_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マリアーノ・グスマン";
        this.cardName2 = "ハンサムな求婚者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
