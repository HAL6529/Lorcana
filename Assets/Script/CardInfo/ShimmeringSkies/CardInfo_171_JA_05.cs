using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_171_JA_05 : CardInfo
{
    public CardInfo_171_JA_05()
    {
        this.cardNo = "171_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スティッチ";
        this.cardName2 = "大穴チーム";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KarenHallion;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
