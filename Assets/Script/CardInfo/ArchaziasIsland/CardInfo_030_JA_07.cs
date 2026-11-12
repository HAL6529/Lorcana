using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_030_JA_07 : CardInfo
{
    public CardInfo_030_JA_07()
    {
        this.cardNo = "030_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "キナイ";
        this.cardName2 = "世話焼きお兄ちゃん";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JulienVandois;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
