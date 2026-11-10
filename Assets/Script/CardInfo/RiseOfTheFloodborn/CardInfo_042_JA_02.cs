using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_02 : CardInfo
{
    public CardInfo_042_JA_02()
    {
        this.cardNo = "042_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フェアリーゴッドマザー";
        this.cardName2 = "純粋な心";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MattChapman;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
