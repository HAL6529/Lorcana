using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_135_JA_07 : CardInfo
{
    public CardInfo_135_JA_07()
    {
        this.cardNo = "135_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ファントムブロット";
        this.cardName2 = "正体不明の人影";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LucaPinelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
