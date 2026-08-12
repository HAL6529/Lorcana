using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_01 : CardInfo
{
    public CardInfo_122_JA_01()
    {
        this.cardNo = "122_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スカー";
        this.cardName2 = "焦熱の野心家";
        this.power = 5;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Amber Kommavongsa";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
