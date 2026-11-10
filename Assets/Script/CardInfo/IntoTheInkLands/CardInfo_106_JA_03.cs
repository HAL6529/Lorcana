using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_106_JA_03 : CardInfo
{
    public CardInfo_106_JA_03()
    {
        this.cardNo = "106_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "デラ・ダック";
        this.cardName2 = "無敵のママ";
        this.power = 3;
        this.toughness = 3;
        this.lore = 0;
        this.illustrator = EnumController.Illustrator.RudyAndHill;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
