using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_186_JA_01 : CardInfo
{
    public CardInfo_186_JA_01()
    {
        this.cardNo = "186_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "銃士";
        this.power = 2;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = "Joschem Van Gool";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
