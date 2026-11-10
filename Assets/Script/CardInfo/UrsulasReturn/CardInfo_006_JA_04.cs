using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_006_JA_04 : CardInfo
{
    public CardInfo_006_JA_04()
    {
        this.cardNo = "006_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "愛しのレディ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
