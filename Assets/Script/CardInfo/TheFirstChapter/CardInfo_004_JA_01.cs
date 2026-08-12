using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_004_JA_01 : CardInfo
{
    public CardInfo_004_JA_01()
    {
        this.cardNo = "004_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "従士";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Jochem Van Gool";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Musketeer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
