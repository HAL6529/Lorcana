using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_02 : CardInfo
{
    public CardInfo_011_JA_02()
    {
        this.cardNo = "011_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "‚²‚«‚°‚ñ";
        this.cardName2 = "‚Ù‚ª‚ç‚©";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
