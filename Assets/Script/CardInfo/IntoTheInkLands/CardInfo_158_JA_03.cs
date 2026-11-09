using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_158_JA_03 : CardInfo
{
    public CardInfo_158_JA_03()
    {
        this.cardNo = "158_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ウェンディ・ダーリング";
        this.cardName2 = "ピーター・パン博士";
        this.power = 3;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulieVu;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
