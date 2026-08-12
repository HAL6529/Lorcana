using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_01 : CardInfo
{
    public CardInfo_144_JA_01()
    {
        this.cardNo = "144_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルド・ダック";
        this.cardName2 = "発明自慢";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Cam Kendell";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
