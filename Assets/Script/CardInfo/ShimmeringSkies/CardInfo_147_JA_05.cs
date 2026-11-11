using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_147_JA_05 : CardInfo
{
    public CardInfo_147_JA_05()
    {
        this.cardNo = "147_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "プリンス・ジョン";
        this.cardName2 = "お金大好き";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
