using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_154_JA_01 : CardInfo
{
    public CardInfo_154_JA_01()
    {
        this.cardNo = "154_JA_01";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "名探偵";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Jared Nickerl";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
