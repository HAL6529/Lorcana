using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_05 : CardInfo
{
    public CardInfo_089_JA_05()
    {
        this.cardNo = "089_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "マザー・ゴーテル";
        this.cardName2 = "自惚れ屋で支配的";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
