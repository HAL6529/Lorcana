using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_04 : CardInfo
{
    public CardInfo_105_JA_04()
    {
        this.cardNo = "105_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ファ・ズー";
        this.cardName2 = "ムーランの父";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
