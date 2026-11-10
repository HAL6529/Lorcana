using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_03 : CardInfo
{
    public CardInfo_175_JA_03()
    {
        this.cardNo = "175_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉwÉãÉKÅEÉVÉìÉNÉåÉA";
        this.cardName2 = "éióﬂäØÇÃâEòr";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KasiaBrzezinska;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
