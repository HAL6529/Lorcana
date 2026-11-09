using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_010_JA_02 : CardInfo
{
    public CardInfo_010_JA_02()
    {
        this.cardNo = "010_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‚¨‚±‚è‚ñ‚Ú";
        this.cardName2 = "‹C“ï‚µ‰®";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.SevenDwarfs };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
