using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_01 : CardInfo
{
    public CardInfo_147_JA_01()
    {
        this.cardNo = "147_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ÉnÉfÉX";
        this.cardName2 = "ñªï{ÇÃçÙñdâ∆";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Matthew Robert Davies";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
