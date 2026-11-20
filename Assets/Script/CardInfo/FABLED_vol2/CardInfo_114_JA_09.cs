using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_09 : CardInfo
{
    public CardInfo_114_JA_09()
    {
        this.cardNo = "114_JA_09";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "P. J. ピート";
        this.cardName2 = "超ノリノリ";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
