using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_07 : CardInfo
{
    public CardInfo_090_JA_07()
    {
        this.cardNo = "090_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ヒロ・ハマダ";
        this.cardName2 = "未来のチャンピオン";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JenniferWu;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
