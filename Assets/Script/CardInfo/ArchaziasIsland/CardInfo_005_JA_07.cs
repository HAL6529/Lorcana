using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_07 : CardInfo
{
    public CardInfo_005_JA_07()
    {
        this.cardNo = "005_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ロジャー・ラドクリフ";
        this.cardName2 = "愛犬家";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
