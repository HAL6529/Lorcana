using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_07 : CardInfo
{
    public CardInfo_145_JA_07()
    {
        this.cardNo = "145_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マイロ・サッチ";
        this.cardName2 = "不屈の学者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
