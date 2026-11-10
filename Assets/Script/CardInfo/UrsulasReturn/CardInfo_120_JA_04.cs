using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_120_JA_04 : CardInfo
{
    public CardInfo_120_JA_04()
    {
        this.cardNo = "120_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ペガサス";
        this.cardName2 = "空を翔ける馬";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
