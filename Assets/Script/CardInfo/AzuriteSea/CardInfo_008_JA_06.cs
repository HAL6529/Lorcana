using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_008_JA_06 : CardInfo
{
    public CardInfo_008_JA_06()
    {
        this.cardNo = "008_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "デイヴィッド";
        this.cardName2 = "颯爽たるサーファー";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinPalombo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
