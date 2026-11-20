using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_112_JA_09 : CardInfo
{
    public CardInfo_112_JA_09()
    {
        this.cardNo = "112_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マックス・グーフ";
        this.cardName2 = "ロック少年";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
