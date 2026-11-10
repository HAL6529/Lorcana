using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_016_JA_04 : CardInfo
{
    public CardInfo_016_JA_04()
    {
        this.cardNo = "016_JA_04";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "銃士隊の隊長";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Musketeer, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
