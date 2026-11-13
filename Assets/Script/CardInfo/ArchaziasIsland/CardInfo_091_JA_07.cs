using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_07 : CardInfo
{
    public CardInfo_091_JA_07()
    {
        this.cardNo = "091_JA_07";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "チェシャ猫";
        this.cardName2 = "ややこしいネコ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SandaraTang;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
