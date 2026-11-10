using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_176_JA_04 : CardInfo
{
    public CardInfo_176_JA_04()
    {
        this.cardNo = "176_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "çdîÁÇ»ÇÈé“";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimangalisoSibaya;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
