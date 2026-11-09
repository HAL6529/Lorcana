using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_02 : CardInfo
{
    public CardInfo_040_JA_02()
    {
        this.cardNo = "040_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "フェアリーゴッドマザー";
        this.cardName2 = "助けにきたわよ";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
