using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_04 : CardInfo
{
    public CardInfo_015_JA_04()
    {
        this.cardNo = "015_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "バンドリーダー";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
