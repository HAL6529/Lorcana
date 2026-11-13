using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_07 : CardInfo
{
    public CardInfo_170_JA_07()
    {
        this.cardNo = "170_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "抜け目ないヤツ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
