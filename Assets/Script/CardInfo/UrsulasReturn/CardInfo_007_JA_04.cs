using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_007_JA_04 : CardInfo
{
    public CardInfo_007_JA_04()
    {
        this.cardNo = "007_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "銃士隊のスパイ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
