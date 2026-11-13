using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_07 : CardInfo
{
    public CardInfo_195_JA_07()
    {
        this.cardNo = "195_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ミス・ビアンカ";
        this.cardName2 = "あきらめないエージェント";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MariaDresden;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
