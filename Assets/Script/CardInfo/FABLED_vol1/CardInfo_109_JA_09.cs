using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_109_JA_09 : CardInfo
{
    public CardInfo_109_JA_09()
    {
        this.cardNo = "109_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "パワーライン";
        this.cardName2 = "オン・ステージ！";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
